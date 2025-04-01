using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.Device
{
    internal class Watering : ITreeDisplayed
    {
        public bool Enabled { get; set; }
        public bool Auto { get; set; }
        public string Name => "Watering";
        public string Time { get; set; } = string.Empty;
        public Bitmap? StateIcon => Auto ? Res.gears : Res.hand_point;
        public string StateText => (Enabled ? (Auto ? "Auto" : "Manual")  : "Disabled") + $" ({Time})";
        public Gate Gate { get; set; } = new Gate();
        public Pump Pump { get; set; } = new Pump();
    }
}
