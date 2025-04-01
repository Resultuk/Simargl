using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl
{
    internal class DeviceState
    {
        public string ID { get; set; } = string.Empty;
        public string Param { get; set; } = string.Empty;
        public byte Area { get; set; }
        public uint DateTime { get; set; }
        public AreaState AS1 { get; set; } = new AreaState();
        public AreaState AS2 { get; set; } = new AreaState();
        public AreaState AS3 { get; set; } = new AreaState();
        public AreaState AS4 { get; set; } = new AreaState();
    }
    internal class AreaState
    {
        public int TW { get; set; }
        public bool Pump { get; set; }
        public bool Gate { get; set; }
        public bool En { get; set; }
        public bool Auto { get; set; }
    }
}
