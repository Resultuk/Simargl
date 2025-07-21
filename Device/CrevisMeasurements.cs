using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.Device
{
    internal class CrevisMeasurements
    {
        public string ID { get; set; } = string.Empty;
        public byte Area { get; set; }
        public string UTC { get; set; } = string.Empty;
        public float? T { get; set; }
        public float? RH { get; set; }
        public float? CO2 { get; set; }
        public float? P { get; set; }
        public float? Load { get; set; }
        public float? Tpcb { get; set; }
        public float? Level { get; set; }
    }
}
