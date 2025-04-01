using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.Device
{
    internal class Pump : ITreeDisplayed
    {
        public bool Running { get; set; } = false;
        public string Name => "Pump";
        public Bitmap? StateIcon => Running ? Simargl.Res.bullet_ball_green : Simargl.Res.bullet_ball_red;
        public string StateText => Running ? "Running" : "Stopped";
    }
}
