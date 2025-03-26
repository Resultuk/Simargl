using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.HorticultureModel
{
    public class GrPhase
    {
        public ushort Loops { get; set; }
        public GrStep[] Steps { get; set; } = new GrStep[12];
        public GrPhase()
        {
            for (int i = 0; i < 12; i++)
            {
                Steps[i] = new GrStep();
            }
        }
        public bool Load(byte[] data)
        {
            if (data.Length < 2) return false;
            Loops = BitConverter.ToUInt16(data, 0);
            if (data.Length < 2 + 12 * 6) return false;
            for (int i = 0; i < 12; i++)
            {
                if (Steps[i] == null) Steps[i] = new GrStep();
                if (!Steps[i].Load(data.Skip(2 + i * 6).Take(6).ToArray())) return false;
            }
            return true;
        }
    }
}
