using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.HorticultureModel
{
    public class AgroRecipe
    {
        public uint StartTime { get; set; }
        public GrPhase[] Phases { get; set; } = new GrPhase[16];
        public AgroRecipe()
        {
            for (int i = 0; i < 16; i++)
            {
                Phases[i] = new GrPhase();
            }
        }
        public bool Load(byte[] data)
        {
            if (data.Length < 4) return false;
            StartTime = BitConverter.ToUInt32(data, 0);
            if (data.Length < 4 + 16 * (2 + 12 * 6)) return false;
            for (int i = 0; i < 16; i++)
            {
                if (Phases[i] == null) Phases[i] = new GrPhase();
                if (!Phases[i].Load(data.Skip(16 + i * 80).Take(80).ToArray())) return false;
            }
            Loaded?.Invoke(this, EventArgs.Empty);
            return true;
        }
        public byte[] GetBytes()
        {
            var data = new List<byte>();
            data.AddRange(BitConverter.GetBytes(StartTime));
            data.AddRange(new byte[12]);
            for (int i = 0; i < 16; i++)
            {
                data.AddRange(BitConverter.GetBytes(Phases[i].Loops));
                for (int j = 0; j < 12; j++)
                {
                    data.AddRange(BitConverter.GetBytes(Phases[i].Steps[j].Period));
                    data.Add(Phases[i].Steps[j].CH1);
                    data.Add(Phases[i].Steps[j].CH2);
                    data.Add(Phases[i].Steps[j].CH3);
                    data.Add(Phases[i].Steps[j].CH4);
                }
                data.AddRange(new byte[6]);
            }
            return data.ToArray();
        }
        public void Fill()
        {
            for (int i = 0; i < 16; i++)
            {
                Phases[i].Loops = (ushort)((i + 1) * 2);
                for (int j = 0; j < 12; j++)
                {
                    Phases[i].Steps[j].Period = (ushort)((j + 1 + i) * 100);
                    Phases[i].Steps[j].CH1 = (byte)(j + i);
                    Phases[i].Steps[j].CH2 = (byte)(j + 10 + i);
                    Phases[i].Steps[j].CH3 = (byte)(j + 20 + i);
                    Phases[i].Steps[j].CH4 = (byte)(j + 30 + i);
                }
            }
        }
        public event EventHandler? Loaded;
    }
}
