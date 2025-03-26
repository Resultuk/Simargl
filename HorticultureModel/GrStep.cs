using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.HorticultureModel
{
    public class GrStep
    {
        public ushort Period { get; set; }
        public byte CH1 { get; set; }
        public byte CH2 { get; set; }
        public byte CH3 { get; set; }
        public byte CH4 { get; set; }
        public bool Load(byte[] data)
        {
            if (data.Length < 6) return false;
            Period = BitConverter.ToUInt16(data, 0);
            CH1 = data[2];
            CH2 = data[3];
            CH3 = data[4];
            CH4 = data[5];
            return true;
        }
    }
}
