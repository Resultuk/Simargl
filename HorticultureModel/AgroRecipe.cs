using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.HorticultureModel
{
    internal class AgroRecipe
    {
        public uint StartTime { get; set; }
        public GrPhase[] Phases { get; set; } = new GrPhase[16];
        public bool Load(byte[] data)
        {
            if (data.Length < 4) return false;
            StartTime = BitConverter.ToUInt32(data, 0);
            if (data.Length < 4 + 16 * (2 + 12 * 6)) return false;
            for (int i = 0; i < 16; i++)
            {
                if (Phases[i] == null) Phases[i] = new GrPhase();
                if (!Phases[i].Load(data.Skip(16 + i * (2 + 12 * 6)).Take(2 + 12 * 6).ToArray())) return false;
            }
            return true;
        }
    }
}
