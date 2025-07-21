using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simargl.HorticultureModel;

namespace Simargl
{
    public partial class ucWatering : UserControl
    {
        #region Private
        private WaterClass settings = new WaterClass();
        #endregion
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public WaterClass WaterSettings 
        { 
            get => settings; 
            set
            {
                if (settings.Equals(value)) return;
                WaterSettings.Loaded -= (s, e) => ToControlIfNeedAction();
                settings = value;
                WaterSettings.Loaded += (s, e) => ToControlIfNeedAction();
                ToControlIfNeedAction();
            }
        }
        public ucWatering()
        {
            InitializeComponent();
            WaterSettings.Loaded += (s, e) => ToControlIfNeedAction();
        }
        private void ToControlIfNeedAction()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ToControl()));
            }
            else
            {
                ToControl();
            }
        }
        private void ToControl()
        {
            cbMode.SelectedIndexChanged -= cbMode_SelectedIndexChanged;
            cbMode.SelectedIndex = WaterSettings.Mode >= cbMode.Items.Count ? 0 : WaterSettings.Mode;
            cbMode.SelectedIndexChanged += cbMode_SelectedIndexChanged;

            tBSwtc_ch.TextChanged -= tBLoop_ch_TextChanged;
            tBSwtc_ch.Text = Utils.GetStringForTime(WaterSettings.SwitchToAuto);
            tBSwtc_ch.TextChanged += tBLoop_ch_TextChanged;

            tBWork_ch.TextChanged -= tBLoop_ch_TextChanged;
            tBWork_ch.Text = Utils.GetStringForTime(WaterSettings.WorkTime);
            tBWork_ch.TextChanged += tBLoop_ch_TextChanged;

            tBLoop_ch.TextChanged -= tBLoop_ch_TextChanged;
            tBLoop_ch.Text = Utils.GetStringForTime(WaterSettings.RepeatTime);
            tBLoop_ch.TextChanged += tBLoop_ch_TextChanged;

            dtpStart_ch.ValueChanged -= dtpStart_ch_ValueChanged;
            dtpStart_ch.Value = WaterSettings.Start;
            dtpStart_ch.ValueChanged += dtpStart_ch_ValueChanged;

            dtpEnd_ch.ValueChanged -= dtpEnd_ch_ValueChanged;
            dtpEnd_ch.Value = WaterSettings.Finish;
            dtpEnd_ch.ValueChanged += dtpEnd_ch_ValueChanged;

            cbDontStop.CheckedChanged -= cbDontStop_CheckedChanged;
            cbDontStop.Checked = WaterSettings.DoNotStop;
            cbDontStop.CheckedChanged += cbDontStop_CheckedChanged;

            tbLevelMin1.TextChanged -= tBLoop_ch_TextChanged;
            tbLevelMin1.Text = WaterSettings.MinLevel.ToString();
            tbLevelMin1.TextChanged += tBLoop_ch_TextChanged;

            tbLevelMax1.TextChanged -= tBLoop_ch_TextChanged;
            tbLevelMax1.Text = WaterSettings.MaxLevel.ToString();
            tbLevelMax1.TextChanged += tBLoop_ch_TextChanged;

            nudLevelNetAddr1.ValueChanged -= nudLevelNetAddr1_ValueChanged;
            nudLevelNetAddr1.Value = WaterSettings.LevelNetAddress < 129 ? 129 : WaterSettings.LevelNetAddress;
            nudLevelNetAddr1.ValueChanged += nudLevelNetAddr1_ValueChanged;

            chbLevel1.CheckedChanged -= chbLevel1_CheckedChanged;
            chbLevel1.Checked = WaterSettings.LevelOn;
            chbLevel1.CheckedChanged += chbLevel1_CheckedChanged;

            nudLevelNetAddr1.Enabled = chbLevel1.Checked;
            dtpEnd_ch.Enabled = !cbDontStop.Checked;
        }
        private void dtpStart_ch_ValueChanged(object? sender, EventArgs e)
        {
            WaterSettings.Start = dtpStart_ch.Value;
        }
        private void dtpEnd_ch_ValueChanged(object? sender, EventArgs e)
        {
            WaterSettings.Finish = dtpEnd_ch.Value;
        }
        private void cbDontStop_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                WaterSettings.DoNotStop = checkBox.Checked;
                ToControl();
            }
        }
        private void cbMode_SelectedIndexChanged(object? sender, EventArgs e)
        {
            WaterSettings.Mode = (ushort)cbMode.SelectedIndex;
        }
        private void tBLoop_ch_TextChanged(object? sender, EventArgs e)
        {
            if (sender == null) return;
            TextBox textBox = (TextBox)sender;
            switch (textBox.Name)
            {
                case "tBLoop_ch":
                    if (TimeSpan.TryParse(textBox.Text, out TimeSpan timeSpan))
                    {
                        WaterSettings.RepeatTime = (ushort)timeSpan.TotalSeconds;
                    }
                    break;
                case "tBWork_ch":
                    if (TimeSpan.TryParse(textBox.Text, out timeSpan))
                    {
                        WaterSettings.WorkTime = (ushort)timeSpan.TotalSeconds;
                    }
                    break;
                case "tBSwtc_ch":
                    if (TimeSpan.TryParse(textBox.Text, out timeSpan))
                    {
                        WaterSettings.SwitchToAuto = (ushort)timeSpan.TotalSeconds;
                    }
                    break;
                case "tbLevelMin1":
                    if (ushort.TryParse(textBox.Text, out ushort value))
                    {
                        WaterSettings.MinLevel = value;
                    }
                    break;
                case "tbLevelMax1":
                    if (ushort.TryParse(textBox.Text, out value))
                    {
                        WaterSettings.MaxLevel = value;
                    }
                    break;
            }
        }

        private void nudLevelNetAddr1_ValueChanged(object? sender, EventArgs e)
        {
            if (sender is NumericUpDown numericUpDown)
            {
                WaterSettings.LevelNetAddress = (byte)numericUpDown.Value;
            }
        }
        private void chbLevel1_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                WaterSettings.LevelOn = checkBox.Checked;
                ToControl();
            }
        }
    }
}
