using Aga.Controls.Tree;
using Aga.Controls.Tree.NodeControls;
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
                                                .Select(x => Convert.ToByte(new string(new char[] { (value.ToString())[x * 2 + 1], (value.ToString())[x * 2] }), 16))
                                                .ToArray();
                                            areaObj.AgroRecipe.Load(bytes);
                                            Invoke(new Action(() => ShowData()));
                                        }
                                        else if (param.ToString() == "Watering")
                                        {
                                            var bytes = Enumerable.Range(0, (value.ToString()).Length / 2)
                                                .Select(x => Convert.ToByte(new string(new char[] { (value.ToString())[x * 2 + 1], (value.ToString())[x * 2] }), 16))
                                                .ToArray();
                                            areaObj.WaterClass.Load(bytes);
                                            Invoke(new Action(() => ShowData()));
                                        }
                                        else if (param.ToString() == "Identity")
                                        {
                                            var bytes = Enumerable.Range(0, (value.ToString()).Length / 2)
                                                .Select(x => Convert.ToByte(new string(new char[] { (value.ToString())[x * 2 + 1], (value.ToString())[x * 2] }), 16))
                                                .ToArray();
                                            areaObj.SubDevIDs.Load(bytes);
                                            Invoke(new Action(() => ShowData()));
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

            dataGridView1.Rows.Add(12);

            comboBox1.SelectedIndex = 0;

            for (int i = 0; i < 12; i++)
            {
                dataGridView1.Rows[i].HeaderCell.Value = $"Step - {i + 1}";
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
                    labSelectedDevice.Text = value == 0 ? "Off" : value + " %";
                }
            }
        }

        private void dataGridView1_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (mainTree.SelectedNode.Tag is Area area)
            {
                var index = comboBox1.SelectedIndex;
                if (index < 0) return;
                var step = area.AgroRecipe.Phases[index].Steps[e.RowIndex];
                if (e.ColumnIndex == 0)
                {
                    if (ushort.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out ushort res))
                    {
                        step.Period = Convert.ToUInt16(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    }
                    else
                    {
                        dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                        dataGridView1.Rows[e.RowIndex].Cells[0].Value = step.Period;
                        dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                    }
                }
                else if (e.ColumnIndex == 1)
                {
                    if (byte.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out byte res))
                    {
                        step.CH1 = Convert.ToByte(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                    }
                    else
                    {
                        dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                        dataGridView1.Rows[e.RowIndex].Cells[1].Value = step.CH1;
                        dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                    }
                }
                else if (e.ColumnIndex == 2)
                {
                    if (byte.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out byte res))
                    {
                        step.CH2 = Convert.ToByte(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    }
                    else
                    {
                        dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = step.CH2;
                        dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                    }
                }
                else if (e.ColumnIndex == 3)
                {
                    if (byte.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out byte res))
                    {
                        step.CH3 = Convert.ToByte(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                    }
                    else
                    {
                        dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                        dataGridView1.Rows[e.RowIndex].Cells[3].Value = step.CH3;
                        dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                    }
                }
                else if (e.ColumnIndex == 4)
                {
                    if (byte.TryParse(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out byte res))
                    {
                        step.CH4 = Convert.ToByte(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                    }
                    else
                    {
                        dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                        dataGridView1.Rows[e.RowIndex].Cells[4].Value = step.CH4;
                        dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                    }
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode.Tag is Area area)
            {
                var index = comboBox1.SelectedIndex;
                if (index < 0) return;
                area.AgroRecipe.Phases[index].Loops = Convert.ToByte(numericUpDown1.Value);
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 && e.Control)
            {
                if (mainTree.SelectedNode.Tag is Area area)
                {
                    area.AgroRecipe.Fill();
                    ShowData();
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object? sender, EventArgs e)
        {
            if (mainTree.SelectedNode.Tag is Area area)
            {
                DateTimeOffset dateTimeOffset = new DateTimeOffset(dateTimePicker1.Value);
                area.AgroRecipe.StartTime = (uint)dateTimeOffset.ToUnixTimeSeconds();
            }
        }
        private void ShowData()
        {
            if (mainTree.SelectedNode.Tag is Area area)
            {
                var index = comboBox1.SelectedIndex;
                if (index < 0) return;
                var phase = area.AgroRecipe.Phases[index];
                numericUpDown1.Value = phase.Loops;
                dateTimePicker1.Value = DateTimeOffset.FromUnixTimeSeconds(area.AgroRecipe.StartTime).DateTime;
                for (int i = 0; i < 12; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = phase.Steps[i].Period;
                    dataGridView1.Rows[i].Cells[1].Value = phase.Steps[i].CH1;
                    dataGridView1.Rows[i].Cells[2].Value = phase.Steps[i].CH2;
                    dataGridView1.Rows[i].Cells[3].Value = phase.Steps[i].CH3;
                    dataGridView1.Rows[i].Cells[4].Value = phase.Steps[i].CH4;
                }
            }
        }
    }
}
