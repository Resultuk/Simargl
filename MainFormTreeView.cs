using MQTTnet;
using Simargl.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Simargl
{
    public partial class MainForm
    {
        private void tsmiRead_Click(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode.Tag is Area area)
            {
                var topic = $"command/read";
                var payload = JsonSerializer.Serialize(new { ID = area.Crevis.ToString(), Area = area.Number, Param = $"Illumination" });
                mqttClient.PublishAsync(new MqttApplicationMessageBuilder()
                        .WithTopic(topic)
                        .WithPayload(payload)
                        .Build());
            }

        }
        private void mainTree_SelectionChanged(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode == null)
            {
                tsmiRead.Enabled = false;
                return;
            }
            if (mainTree.SelectedNode.Tag is Area area)
            {
                tsmiRead.Enabled = true;
                dateTimePicker1.Value = DateTimeOffset.FromUnixTimeSeconds(area.AgroRecipe.StartTime).UtcDateTime;
            }
            else
            {
                tsmiRead.Enabled = false;
            }
        }
    }
    public static class DateTimeExtensions
    {
        public static DateTime FromUnixTimeSecondsToUtcDateTime(this uint unixTime)
        {
            return DateTimeOffset.FromUnixTimeSeconds(unixTime).UtcDateTime;
        }
    }
}
