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
        private void mainTree_SelectionChanged(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode == null || mainTree.SelectedNode.Tag == null) return;
            if (mainTree.SelectedNode.Tag is Area area)
            {
                labSelectedDevice.Text = $"Selected device: {area.Crevis.Name}; Area #{area.Number}";
            }
        }
        private void tsmiRead_Click(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode == null || mainTree.SelectedNode.Tag == null) return;
            if (mainTree.SelectedNode.Tag is Area area)
            {
                SendMqttMessage("command/read", new { ID = area.Crevis.ToString(), Area = area.Number, Param = "Illumination" });
            }
        }
        private void tsmiReadWater_Click(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode == null || mainTree.SelectedNode.Tag == null) return;
            if (mainTree.SelectedNode.Tag is Area area)
            {
                SendMqttMessage("command/read", new { ID = area.Crevis.ToString(), Area = area.Number, Param = "Watering" });
            }
        }
        private void tsmiWrite_Click(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode == null || mainTree.SelectedNode.Tag == null) return;
            if (mainTree.SelectedNode.Tag is Area area)
            {
                SendMqttMessage("command/write", new { ID = area.Crevis.ToString(), Area = area.Number, Param = "Illumination", Value = area.AgroRecipe.GetBytes().ToHexString(true) });
            }
        }
        private void tsmiWriteWater_Click(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode == null || mainTree.SelectedNode.Tag == null) return;
            if (mainTree.SelectedNode.Tag is Area area)
            {
                SendMqttMessage("command/write", new { ID = area.Crevis.ToString(), Area = area.Number, Param = "Watering", Value = area.WaterClass.GetBytes().ToHexString(true) });
            }
        }
        private void tsbReadIDs_Click(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode == null || mainTree.SelectedNode.Tag == null) return;
            if (mainTree.SelectedNode.Tag is Area area)
            {
                SendMqttMessage("command/read", new { ID = area.Crevis.ToString(), Area = area.Number, Param = "Identity" });
            }
        }
        private void tsbWriteID_Click(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode == null || mainTree.SelectedNode.Tag == null) return;
            if (mainTree.SelectedNode.Tag is Area area)
            {
                SendMqttMessage("command/write", new { ID = area.Crevis.ToString(), Area = area.Number, Param = "Identity", Value = area.SubDevIDs.GetBytes().ToHexString(true) });
            }
        }
        private void tsbReadWater_Click(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode == null || mainTree.SelectedNode.Tag == null) return;
            if (mainTree.SelectedNode.Tag is Area area)
            {
                SendMqttMessage("command/read", new { ID = area.Crevis.ToString(), Area = area.Number, Param = "Watering" });
            }
        }
        private void tsbWriteWater_Click(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode == null || mainTree.SelectedNode.Tag == null) return;
            if (mainTree.SelectedNode.Tag is Area area)
            {
                SendMqttMessage("command/write", new { ID = area.Crevis.ToString(), Area = area.Number, Param = "Watering", Value = area.WaterClass.GetBytes().ToHexString(true) });
            }
        }
        private void tsbReadIllum_Click(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode == null || mainTree.SelectedNode.Tag == null) return;
            if (mainTree.SelectedNode.Tag is Area area)
            {
                SendMqttMessage("command/read", new { ID = area.Crevis.ToString(), Area = area.Number, Param = "Illumination" });
            }
        }
        private void tsbWriteIllum_Click(object sender, EventArgs e)
        {
            if (mainTree.SelectedNode == null || mainTree.SelectedNode.Tag == null) return;
            if (mainTree.SelectedNode.Tag is Area area)
            {
                SendMqttMessage("command/write", new { ID = area.Crevis.ToString(), Area = area.Number, Param = "Illumination", Value = area.AgroRecipe.GetBytes().ToHexString(true) });
            }
        }
        private void SendMqttMessage(string topic, object payload)
        {
            var message = new MqttApplicationMessageBuilder()
                .WithTopic(topic)
                .WithPayload(JsonSerializer.Serialize(payload))
                .Build();
            mqttClient.PublishAsync(message);
        }
    }
    public static class ByteArrayExtensions
    {
        public static string ToHexString(this byte[] bytes, bool needSwap = false)
        {
            if (needSwap)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    bytes[i] = (byte)((bytes[i] << 4) | (bytes[i] >> 4));
                }
            }
            return BitConverter.ToString(bytes).Replace("-", "");
        }
    }
}
