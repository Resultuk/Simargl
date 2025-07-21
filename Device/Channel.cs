using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.Device
{
    internal class Channel : ITreeDisplayed
    {
        public byte Value { get; set; }
        public string Name => $"{ParameterName} ({Description})";
        public string ParameterName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Bitmap? StateIcon => Value > 0 ? Simargl.Res.bullet_ball_yellow : Simargl.Res.bullet_ball_grey;
        public string StateText => Value > 0 ? $"{Value}%" : "Off";
    }
}
