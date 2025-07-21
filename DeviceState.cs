using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl
{
    internal class DeviceState
    {
        public int DateTime { get; set; }
        public AreaState SA1 { get; set; } = new AreaState();
        public AreaState SA2 { get; set; } = new AreaState();
        public AreaState SA3 { get; set; } = new AreaState();
        public AreaState SA4 { get; set; } = new AreaState();
    }
    internal class AreaState
    {
        public byte A { get; set; }
        public WaterState SW { get; set; } = new WaterState();
        public IlluminationState SI { get; set; } = new IlluminationState();
    }
    internal class WaterState
    {
        public int TW { get; set; }
        public bool En { get; set; }
        public bool Auto { get; set; }
        public bool Pump { get; set; }
        public bool Gate { get; set; }
    }
    internal class IlluminationState
    {
        public int TW { get; set; }
        public bool En { get; set; }
        public bool Auto { get; set; }
        public bool Q { get; set; }
        public byte PH { get; set; } // phase
        public byte LP { get; set; } // loop
        public byte SP { get; set; } // step
        public byte CH1 { get; set; } // channel 1
        public byte CH2 { get; set; } // channel 2
        public byte CH3 { get; set; } // channel 3
        public byte CH4 { get; set; } // channel 4
    }
}
