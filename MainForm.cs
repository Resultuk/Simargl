using MQTTnet;
using System.Text;
using Aga.Controls.Tree.NodeControls;
using Simargl.Device;
using System.Text.Json;
using Aga.Controls.Tree;

namespace Simargl
{
    public partial class MainForm : Form
    {
        public const string Host = "192.168.2.71";
        public const string Username = "result";
        public const string Password = "R2D2R2D2";
        private MqttClient mqttClient;

        private NodeTextBox nodeName;
        private static Dictionary<string, Crevis> devices = new Dictionary<string, Crevis>();
        private ModelForTree model = new ModelForTree(devices);
        public MainForm()
        {
            InitializeComponent();
            CreateNode();
            var mqttFactory = new MqttClientFactory();
            mqttClient = (MqttClient?)mqttFactory.CreateMqttClient();
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
                            if (devices.TryGetValue(id.ToString(), out var crevis))
                            {
                                if (int.TryParse(area.ToString(), out var areaNumber))
                                {
                                    var areaObj = crevis.Areas.FirstOrDefault(a => a.Number == areaNumber);
                                    if (areaObj != null)
                                    {
                                        if (param.ToString() == "Illumination")
                                        {
                                            var bytes = Enumerable.Range(0, (value.ToString()).Length / 2)
                                                .Select(x => Convert.ToByte((value.ToString()).Substring(x * 2, 2), 16))
                                                .ToArray();
                                            areaObj.AgroRecipe.Load(bytes);
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {

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
                MessageBox.Show("Disconnected");
            };

            mqttClient.ConnectAsync(options);
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
            mainTree.Model = model;
        }
        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            // Получаем текущую вкладку
            TabControl tc = (TabControl)sender;
            TabPage tabPage = tc.TabPages[e.Index];

            // Настраиваем стиль текста
            StringFormat stringFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            // Рисуем текст горизонтально
            e.Graphics.DrawString(tabPage.Text, e.Font, Brushes.Black, e.Bounds, stringFormat);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            using (var dialog = new TrackBarDialog(Cursor.Position))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    int value = dialog.SelectedValue;
                    label1.Text = value == 0 ? "Off" : value + " %";
                }
            }
        }
    }
}
