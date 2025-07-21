using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.Device
{
    public class Param : ITreeDisplayed
    {
        public Param(string name, string unit)
        {
            Name = name;
            Unit = unit;
        }
        public string Name { get; }
        public string Unit { get; }
        public float Value { get; set; } = 0;
        public Bitmap? StateIcon => null;
        public string StateText => $"{Value} {Unit}";
    }
}
