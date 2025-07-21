using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.Device
{
    internal class Lighting : ITreeDisplayed
    {
        public bool Enabled { get; set; }
        public bool Auto { get; set; }
        public string Name => "Lighting";
        public string Time { get; set; } = string.Empty;
        public Bitmap? StateIcon => Auto ? Res.gears : Res.hand_point;
        public string StateText => (Enabled ? (Auto ? "Auto" : "Manual") : "Disabled") + $" ({Time})";
        public byte PhaseNumber { get; set; }
        public byte LoopNumber { get; set; }
        public byte StepNumber { get; set; }
        public Channel CH1 { get; set; } = new Channel() { ParameterName = "CH1", Description = "B" };
        public Channel CH2 { get; set; } = new Channel() { ParameterName = "CH2", Description = "R" };
        public Channel CH3 { get; set; } = new Channel() { ParameterName = "CH3", Description = "DB" };
        public Channel CH4 { get; set; } = new Channel() { ParameterName = "CH4", Description = "FR" };
    }
}
