using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.Device
{
    internal class Gate : ITreeDisplayed
    {
        public bool IsOpen { get; set; } = false;
        public string Name => "Gate";
        public Bitmap? StateIcon => IsOpen ? Simargl.Res.bullet_ball_green : Simargl.Res.bullet_ball_red;
        public string StateText => IsOpen ? "Open" : "Closed";
    }
}
