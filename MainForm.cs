using Aga.Controls.Tree;
using Aga.Controls.Tree.NodeControls;
using Growor.Recipe;
using MQTTnet;
using Simargl.Device;
using System;
using System.Text;
using System.Text.Json;

namespace Simargl
{
    public partial class MainForm : Form
    {
        public const string Host = "192.168.2.71";
        public const string Username = "result";
        public const string Password = "R2D2R2D2";
        private MqttClient? mqttClient;

        private NodeTextBox? nodeName;
        private NodeTextBox? nodeTime;
        private static Dictionary<string, Crevis> devices = new Dictionary<string, Crevis>();
        private ModelForTree model = new ModelForTree(devices);
        public MainForm()
        {
            InitializeComponent();
            CreateNode();
            var mqttFactory = new MqttClientFactory();
            mqttClient = (MqttClient?)mqttFactory.CreateMqttClient();

            if (mqttClient != null)
            {
                var options = new MqttClientOptionsBuilder()
                    .WithTcpServer(Host)
                    .WithCredentials(Username, Password)
                    .WithClientId("Simargl")
                    .Build();
                mqttClient.ApplicationMessageReceivedAsync += async eventArgs =>
                {
                    var message = eventArgs.ApplicationMessage;
                    if (message.Topic.StartsWith("info/"))
                    {
                        var payload = Encoding.UTF8.GetString(message.Payload);
                        var data = JsonSerializer.Deserialize<Dictionary<string, string>>(payload);
                        if (data == null)
                        {
                            return;
                        }
                        if (data.TryGetValue("ID", out var id))
                        {
                            if (!devices.ContainsKey(id))
                            {
                                var res = Convert.ToUInt64(id, 16);
                                devices.Add(id, new Crevis { ID = res });
                                model.NotifyStructureChanged(TreePath.Empty);
                            }
                        }
                    }
                    else if (message.Topic == "command/response")
                    {
                        var payload = Encoding.UTF8.GetString(message.Payload);
                        var data = JsonSerializer.Deserialize<Dictionary<string, object>>(payload);
                        if (data == null) return;
                        if (data.TryGetValue("ID", out var id) && data.TryGetValue("Area", out var area) && data.TryGetValue("Param", out var param) && data.TryGetValue("Value", out var value))
                        {
                            try
                            {
                                if (id != null && devices.TryGetValue(id.ToString()!, out var crevis))
                                {
                                    if (int.TryParse(area.ToString(), out var areaNumber))
                                    {
                                        var areaObj = crevis.Areas.FirstOrDefault(a => a.Number == areaNumber);
                                        if (areaObj != null && value != null)
                                        {
                                            AppendToRichTextBoxWithInvoke($"- {param} - response");
                                            if (param.ToString() == "Illumination")
                                            {
                                                var bytes = Enumerable.Range(0, (value.ToString()!).Length / 2)
                                                    .Select(x => Convert.ToByte(new string(new char[] { (value.ToString()!)[x * 2 + 1], (value.ToString()!)[x * 2] }), 16))
                                                    .ToArray();
                                                areaObj.AgroRecipe.Load(bytes);
                                            }
                                            else if (param.ToString() == "Watering")
                                            {
                                                var bytes = Enumerable.Range(0, (value.ToString()!).Length / 2)
                                                    .Select(x => Convert.ToByte(new string(new char[] { (value.ToString()!)[x * 2 + 1], (value.ToString()!)[x * 2] }), 16))
                                                    .ToArray();
                                                areaObj.WaterClass.Load(bytes);
                                            }
                                            else if (param.ToString() == "Identity")
                                            {
                                                var bytes = Enumerable.Range(0, (value.ToString()!).Length / 2)
                                                    .Select(x => Convert.ToByte(new string(new char[] { (value.ToString()!)[x * 2 + 1], (value.ToString()!)[x * 2] }), 16))
                                                    .ToArray();
                                                areaObj.SubDevIDs.Load(bytes);
                                            }
                                        }
                                    }
                                }
                            }
                            catch (Exception)
                            {

                            }
                        }
                        else if (data.TryGetValue("DeviceState", out var ds))
                        {
                            var deviceState = JsonSerializer.Deserialize<DeviceState>(ds.ToString());
                            if (deviceState != null)
                            {
                                if (devices.TryGetValue(deviceState.ID.ToString()!, out var crevis))
                                {
                                    crevis.Time = DateTimeOffset.FromUnixTimeSeconds(deviceState.DateTime).DateTime.ToString("dd.MM.yyyy HH:mm:ss");
                                    crevis.Areas[0].Time = GetStringForTime(deviceState.AS1.TW);
                                    crevis.Areas[1].Time = GetStringForTime(deviceState.AS2.TW);
                                    crevis.Areas[2].Time = GetStringForTime(deviceState.AS3.TW);
                                    crevis.Areas[3].Time = GetStringForTime(deviceState.AS4.TW);
                                    model.NotifyStructureChanged(mainTree.GetPath(mainTree.FindNodeByTag(crevis)));
                                }
                            }
                        }
                    }
                    await Task.CompletedTask;
                };

                mqttClient.ConnectedAsync += async eventArgs =>
                {
                    await mqttClient.SubscribeAsync(new MqttTopicFilterBuilder().WithTopic("info/#").Build());
                    await mqttClient.SubscribeAsync(new MqttTopicFilterBuilder().WithTopic("command/response").Build());
                };
                mqttClient.DisconnectedAsync += async eventArgs =>
                {
                    await Task.Run(() =>
                    {
                        AppendToRichTextBoxWithInvoke(Text = "Disconnected from Mosquitto");
                    });
                };

                mqttClient.ConnectAsync(options);
            }
            ApplyingSettings();
        }
        private string GetStringForTime(uint time)
        {
            return $"{(time % 86400 / 3600).ToString().PadLeft(2, '0')}:{(time % 3600 / 60).ToString().PadLeft(2, '0')}:{(time % 60).ToString().PadLeft(2, '0')}";
        }
        private void AppendToRichTextBox(string text)
        {
            richTextBox1.Text = $"{DateTime.Now:yyyy.MM.dd HH:mm:ss.fff} - {text};\n" + richTextBox1.Text;
        }
        private void AppendToRichTextBoxWithInvoke(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new System.Action(() => AppendToRichTextBox(text)));
            }
            else
            {
                AppendToRichTextBox(text);
            }
        }
        private void ApplyingSettings()
        {
            if (AppSets.Default.FullScreen)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                StartPosition = FormStartPosition.Manual;
                Location = new Point(AppSets.Default.Location.X, AppSets.Default.Location.Y);
                Size = new Size(AppSets.Default.Size.Width, AppSets.Default.Size.Height);
            }
        }
        private void CreateNode()
        {
            nodeName = new NodeTextBox
            {
                ParentColumn = tcName,
                DataPropertyName = "Name",
                EditEnabled = false,
                LeftMargin = 3,
                TrimMultiLine = true,
                UseCompatibleTextRendering = true
            };
            nodeName.DrawText += (sender, e) =>
            {
                //e.TextColor = System.Drawing.Color.Black;
            };
            mainTree.NodeControls.Add(nodeName);
            nodeTime = new NodeTextBox
            {
                ParentColumn = tcStatus,
                DataPropertyName = "Time",
                EditEnabled = false,
                LeftMargin = 3,
                TrimMultiLine = true,
                UseCompatibleTextRendering = true
            };
            nodeTime.DrawText += (sender, e) =>
            {
                //e.TextColor = System.Drawing.Color.Black;
            };
            mainTree.NodeControls.Add(nodeTime);
            mainTree.Model = model;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            using (var dialog = new TrackBarDialog(Cursor.Position))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    int value = dialog.SelectedValue;
                    labSelectedDevice.Text = value == 0 ? "Off" : value + " %";
                }
            }
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 && e.Control)
            {
                if (mainTree.SelectedNode.Tag is Area area)
                {
                    area.AgroRecipe.Fill();
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AppSets.Default.FullScreen = WindowState == FormWindowState.Maximized;
            if (WindowState != FormWindowState.Maximized)
            {
                AppSets.Default.Location = Location;
                AppSets.Default.Size = Size;
            }
            AppSets.Default.Splitter1 = splitContainer1.SplitterDistance;
            AppSets.Default.Splitter2 = splitContainer2.SplitterDistance;
            AppSets.Default.Save();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = AppSets.Default.Splitter1;
            splitContainer2.SplitterDistance = AppSets.Default.Splitter2;
        }

        private void labSelectedDevice_DoubleClick(object sender, EventArgs e)
        {
            //if (mainTree.SelectedNode.Tag is Area area)
            //{
            //    SendMqttMessage("command/read", new { ID = area.Crevis.ToString(), Area = 0, Param = "State" });
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach ( var item in devices.Keys)
            {
                SendMqttMessage("command/read", new { ID = item, Area = 0, Param = "State" });
            }
        }
    }
}
