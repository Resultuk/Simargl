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
        public const string Host = "result.keenetic.pro";
        public const string Username = "result";
        public const string Password = "R2D2R2D2";
        private MqttClient? mqttClient;

        private NodeTextBox? nodeName;
        private NodeIcon? nodeIconState;
        private NodeTextBox? nodeTextState;

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
                                Invoke(new System.Action(() =>
                                {
                                    model.NotifyStructureChanged(TreePath.Empty);
                                    mainTree.ExpandAll();
                                }));
                            }
                        }
                    }
                    else if (message.Topic == "command/response")
                    {
                        try
                        {
                            var payload = Encoding.UTF8.GetString(message.Payload);
                            var data = JsonSerializer.Deserialize<Dictionary<string, object>>(payload);
                            if (data == null) return;
                            if (data.TryGetValue("ID", out var id) && data.TryGetValue("Area", out var area) && data.TryGetValue("Param", out var param) && data.TryGetValue("Value", out var value))
                            {

                                if (id != null && devices.TryGetValue(id.ToString()!, out var crevis))
                                {
                                    if (int.TryParse(area.ToString(), out var areaNumber))
                                    {
                                        if (areaNumber > -1 && areaNumber < 5)
                                        {
                                            AppendToRichTextBoxWithInvoke($"- {param} - response");
                                            if (param.ToString() == "Illumination")
                                            {
                                                var bytes = Enumerable.Range(0, (value.ToString()!).Length / 2)
                                                    .Select(x => Convert.ToByte(new string(new char[] { (value.ToString()!)[x * 2 + 1], (value.ToString()!)[x * 2] }), 16))
                                                    .ToArray();
                                                crevis.Areas[areaNumber - 1].AgroRecipe.Load(bytes);
                                            }
                                            else if (param.ToString() == "Watering")
                                            {
                                                var bytes = Enumerable.Range(0, (value.ToString()!).Length / 2)
                                                    .Select(x => Convert.ToByte(new string(new char[] { (value.ToString()!)[x * 2 + 1], (value.ToString()!)[x * 2] }), 16))
                                                    .ToArray();
                                                crevis.Areas[areaNumber - 1].WaterClass.Load(bytes);
                                            }
                                            else if (param.ToString() == "Identity")
                                            {
                                                var bytes = Enumerable.Range(0, (value.ToString()!).Length / 2)
                                                    .Select(x => Convert.ToByte(new string(new char[] { (value.ToString()!)[x * 2 + 1], (value.ToString()!)[x * 2] }), 16))
                                                    .ToArray();
                                                crevis.Areas[areaNumber - 1].SubDevIDs.Load(bytes);
                                            }
                                            else if (param.ToString() == "State")
                                            {
                                                var deviceState = JsonSerializer.Deserialize<DeviceState>(value.ToString());
                                                if (deviceState != null)
                                                {

                                                    crevis.Time = DateTimeOffset.FromUnixTimeSeconds(deviceState.DateTime).DateTime.ToString("dd.MM.yyyy HH:mm:ss");
                                                    crevis.Areas[0].Watering.Time = GetStringForTime((uint)deviceState.SA1.SW.TW);
                                                    crevis.Areas[1].Watering.Time = GetStringForTime((uint)deviceState.SA2.SW.TW);
                                                    crevis.Areas[2].Watering.Time = GetStringForTime((uint)deviceState.SA3.SW.TW);
                                                    crevis.Areas[3].Watering.Time = GetStringForTime((uint)deviceState.SA4.SW.TW);

                                                    crevis.Areas[0].Watering.Enabled = deviceState.SA1.SW.En;
                                                    crevis.Areas[1].Watering.Enabled = deviceState.SA2.SW.En;
                                                    crevis.Areas[2].Watering.Enabled = deviceState.SA3.SW.En;
                                                    crevis.Areas[3].Watering.Enabled = deviceState.SA4.SW.En;

                                                    crevis.Areas[0].Watering.Auto = deviceState.SA1.SW.Auto;
                                                    crevis.Areas[1].Watering.Auto = deviceState.SA2.SW.Auto;
                                                    crevis.Areas[2].Watering.Auto = deviceState.SA3.SW.Auto;
                                                    crevis.Areas[3].Watering.Auto = deviceState.SA4.SW.Auto;

                                                    crevis.Areas[0].Watering.Pump.Running = deviceState.SA1.SW.Pump;
                                                    crevis.Areas[1].Watering.Pump.Running = deviceState.SA2.SW.Pump;
                                                    crevis.Areas[2].Watering.Pump.Running = deviceState.SA3.SW.Pump;
                                                    crevis.Areas[3].Watering.Pump.Running = deviceState.SA4.SW.Pump;

                                                    crevis.Areas[0].Watering.Gate.IsOpen = deviceState.SA1.SW.Gate;
                                                    crevis.Areas[1].Watering.Gate.IsOpen = deviceState.SA2.SW.Gate;
                                                    crevis.Areas[2].Watering.Gate.IsOpen = deviceState.SA3.SW.Gate;
                                                    crevis.Areas[3].Watering.Gate.IsOpen = deviceState.SA4.SW.Gate;

                                                    crevis.Areas[0].Lighting.Time = GetStringForTime((uint)deviceState.SA1.SI.TW);
                                                    crevis.Areas[1].Lighting.Time = GetStringForTime((uint)deviceState.SA2.SI.TW);
                                                    crevis.Areas[2].Lighting.Time = GetStringForTime((uint)deviceState.SA3.SI.TW);
                                                    crevis.Areas[3].Lighting.Time = GetStringForTime((uint)deviceState.SA4.SI.TW);

                                                    crevis.Areas[0].Lighting.Enabled = deviceState.SA1.SI.En;
                                                    crevis.Areas[1].Lighting.Enabled = deviceState.SA2.SI.En;
                                                    crevis.Areas[2].Lighting.Enabled = deviceState.SA3.SI.En;
                                                    crevis.Areas[3].Lighting.Enabled = deviceState.SA4.SI.En;

                                                    crevis.Areas[0].Lighting.Auto = deviceState.SA1.SI.Auto;
                                                    crevis.Areas[1].Lighting.Auto = deviceState.SA2.SI.Auto;
                                                    crevis.Areas[2].Lighting.Auto = deviceState.SA3.SI.Auto;
                                                    crevis.Areas[3].Lighting.Auto = deviceState.SA4.SI.Auto;

                                                    crevis.Areas[0].Lighting.LoopNumber = deviceState.SA1.SI.LP;
                                                    crevis.Areas[1].Lighting.LoopNumber = deviceState.SA2.SI.LP;
                                                    crevis.Areas[2].Lighting.LoopNumber = deviceState.SA3.SI.LP;
                                                    crevis.Areas[3].Lighting.LoopNumber = deviceState.SA4.SI.LP;

                                                    crevis.Areas[0].Lighting.StepNumber = deviceState.SA1.SI.SP;
                                                    crevis.Areas[1].Lighting.StepNumber = deviceState.SA2.SI.SP;
                                                    crevis.Areas[2].Lighting.StepNumber = deviceState.SA3.SI.SP;
                                                    crevis.Areas[3].Lighting.StepNumber = deviceState.SA4.SI.SP;

                                                    crevis.Areas[0].Lighting.CH1.Value = deviceState.SA1.SI.CH1;
                                                    crevis.Areas[1].Lighting.CH1.Value = deviceState.SA2.SI.CH1;
                                                    crevis.Areas[2].Lighting.CH1.Value = deviceState.SA3.SI.CH1;
                                                    crevis.Areas[3].Lighting.CH1.Value = deviceState.SA4.SI.CH1;

                                                    crevis.Areas[0].Lighting.CH2.Value = deviceState.SA1.SI.CH2;
                                                    crevis.Areas[1].Lighting.CH2.Value = deviceState.SA2.SI.CH2;
                                                    crevis.Areas[2].Lighting.CH2.Value = deviceState.SA3.SI.CH2;
                                                    crevis.Areas[3].Lighting.CH2.Value = deviceState.SA4.SI.CH2;

                                                    crevis.Areas[0].Lighting.CH3.Value = deviceState.SA1.SI.CH3;
                                                    crevis.Areas[1].Lighting.CH3.Value = deviceState.SA2.SI.CH3;
                                                    crevis.Areas[2].Lighting.CH3.Value = deviceState.SA3.SI.CH3;
                                                    crevis.Areas[3].Lighting.CH3.Value = deviceState.SA4.SI.CH3;

                                                    crevis.Areas[0].Lighting.CH4.Value = deviceState.SA1.SI.CH4;
                                                    crevis.Areas[1].Lighting.CH4.Value = deviceState.SA2.SI.CH4;
                                                    crevis.Areas[2].Lighting.CH4.Value = deviceState.SA3.SI.CH4;
                                                    crevis.Areas[3].Lighting.CH4.Value = deviceState.SA4.SI.CH4;

                                                    Invoke(new System.Action(() => model.NotifyStructureChanged(mainTree.GetPath(mainTree.FindNodeByTag(crevis)))));
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                    else if (message.Topic.StartsWith("measure/"))
                    {
                        var ID = message.Topic.Split('/')[1];
                        var payload = Encoding.UTF8.GetString(message.Payload);
                        var data = JsonSerializer.Deserialize<CrevisMeasurements>(payload);
                        if (data == null)
                        {
                            return;
                        }

                        if (devices.TryGetValue(ID, out Crevis crevis))
                        {
                            if (!crevis.Areas[data.Area - 1].Sensors.List.ContainsKey(data.ID))
                            {
                                if (data.ID.Contains("MixedTank"))
                                    crevis.Areas[data.Area - 1].Sensors.Add(data.ID, enSensorType.Level);
                                else
                                {
                                    if (data.T != null && data.CO2 != null)
                                        crevis.Areas[data.Area - 1].Sensors.Add(data.ID, enSensorType.S4);
                                    else
                                        crevis.Areas[data.Area - 1].Sensors.Add(data.ID, enSensorType.GR500);
                                }
                            }
                            if (data.T != null) crevis.Areas[data.Area - 1].Sensors.List[data.ID].Params["T"].Value = (float)data.T;
                            if (data.RH != null) crevis.Areas[data.Area - 1].Sensors.List[data.ID].Params["RH"].Value = (float)data.RH;
                            if (data.P != null) crevis.Areas[data.Area - 1].Sensors.List[data.ID].Params["P"].Value = (float)data.P;
                            if (data.CO2 != null) crevis.Areas[data.Area - 1].Sensors.List[data.ID].Params["CO2"].Value = (float)data.CO2;
                            if (data.Level != null) crevis.Areas[data.Area - 1].Sensors.List[data.ID].Params["Level"].Value = (float)data.Level;
                            if (data.Load != null) crevis.Areas[data.Area - 1].Sensors.List[data.ID].Params["Load"].Value = (float)data.Load;
                            if (data.Tpcb != null) crevis.Areas[data.Area - 1].Sensors.List[data.ID].Params["Tpcb"].Value = (float)data.Tpcb;
                            model.NotifyStructureChanged(mainTree.GetPath(mainTree.FindNodeByTag(crevis)));
                        }
                    }
                    await Task.CompletedTask;
                };

                mqttClient.ConnectedAsync += async eventArgs =>
                {
                    await mqttClient.SubscribeAsync(new MqttTopicFilterBuilder().WithTopic("info/#").Build());
                    await mqttClient.SubscribeAsync(new MqttTopicFilterBuilder().WithTopic("measure/#").Build());
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

            nodeIconState = new NodeIcon
            {
                ParentColumn = tcControl,
                DataPropertyName = "StateIcon",
                LeftMargin = 3,
            };

            mainTree.NodeControls.Add(nodeIconState);

            nodeTextState = new NodeTextBox
            {
                ParentColumn = tcStatus,
                DataPropertyName = "StateText",
                EditEnabled = false,
                LeftMargin = 3,
                TrimMultiLine = true,
                UseCompatibleTextRendering = true
            };

            mainTree.NodeControls.Add(nodeTextState);

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
            foreach (var item in devices.Keys)
            {
                //SendMqttMessage("command/read", new { ID = item, Area = 0, Param = "State" });
                //Invoke(new System.Action(() =>
                //
                    //SendMqttMessage("command/control", new { ID = item, Area = 1, Param = "Pump", Value = true });
                    //System.Threading.Thread.Sleep(100);
                    //SendMqttMessage("command/control", new { ID = item, Area = 1, Param = "Gate", Value = true });
                    //System.Threading.Thread.Sleep(100);
                    //SendMqttMessage("command/control", new { ID = item, Area = 2, Param = "Pump", Value = true });
                    //System.Threading.Thread.Sleep(100);
                    //SendMqttMessage("command/control", new { ID = item, Area = 2, Param = "Gate", Value = true });
                    //System.Threading.Thread.Sleep(100);
                    //SendMqttMessage("command/control", new { ID = item, Area = 3, Param = "Pump", Value = true });
                    //System.Threading.Thread.Sleep(100);
                    //SendMqttMessage("command/control", new { ID = item, Area = 3, Param = "Gate", Value = true });
                    //System.Threading.Thread.Sleep(100);
                    //SendMqttMessage("command/control", new { ID = item, Area = 4, Param = "Pump", Value = true });
                    //System.Threading.Thread.Sleep(100);
                    //SendMqttMessage("command/control", new { ID = item, Area = 4, Param = "Gate", Value = true });
                //}));
            }
        }

        private void mainTree_NodeMouseClick(object sender, TreeNodeAdvMouseEventArgs e)
        {
            try
            {
                if (e.Control is NodeIcon ni && ni.DataPropertyName == "StateIcon")
                {
                    if (e.Node.Tag is Watering watering)
                    {
                        if (e.Node.Parent.Tag is Area area)
                        {
                            if (e.Node.Parent.Parent.Tag is Crevis crevis)
                            {
                                SendMqttMessage("command/control", new { ID = crevis.ToString(), Area = area.Number, Param = "WaterMode", Value = !watering.Auto });
                            }
                        }
                    }
                    else if (e.Node.Tag is Pump pump)
                    {
                        if (e.Node.Parent.Tag is Watering)
                        {
                            if (e.Node.Parent.Parent.Tag is Area area)
                            {
                                SendMqttMessage("command/control", new { ID = area.Crevis.ToString(), Area = area.Number, Param = "Pump", Value = !pump.Running });
                            }
                        }
                    }
                    else if (e.Node.Tag is Gate gate)
                    {
                        if (e.Node.Parent.Tag is Watering)
                        {
                            if (e.Node.Parent.Parent.Tag is Area area)
                            {

                                SendMqttMessage("command/control", new { ID = area.Crevis.ToString(), Area = area.Number, Param = "Gate", Value = !gate.IsOpen });

                            }
                        }
                    }
                    else if (e.Node.Tag is Lighting lighting)
                    {
                        if (e.Node.Parent.Tag is Area area)
                        {
                            if (e.Node.Parent.Parent.Tag is Crevis crevis)
                            {
                                SendMqttMessage("command/control", new { ID = crevis.ToString(), Area = area.Number, Param = "LightMode", Value = !lighting.Auto });
                            }
                        }
                    }
                    else if (e.Node.Tag is Channel ch)
                    {
                        if (e.Node.Parent.Tag is Lighting)
                        {
                            if (e.Node.Parent.Parent.Tag is Area area)
                            {
                                bool isUp = e.Location.X >  e.ControlBounds.Location.X + e.ControlBounds.Width / 2;
                                SendMqttMessage("command/control", new { ID = area.Crevis.ToString(), Area = area.Number, Param = ch.ParameterName, Value = isUp ? ch.Value + 5 : ch.Value - 5 });
                            }
                        }
                    }
                }
            }
            catch
            {

            }
        }
    }
    
}
