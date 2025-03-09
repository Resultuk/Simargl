using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.Device
{
    internal class Crevis : ITreeDisplayed
    {
        public UInt64 ID { get; set; }
        public Area[] Areas { get; set; }
        public string Name { get => new string(BitConverter.ToString(BitConverter.GetBytes(ID).Reverse().ToArray()).Skip(6).ToArray()); }
        public override string ToString()
        {
            return Name.Replace("-", string.Empty);
        }

        public Crevis()
        {
            Areas = new Area[] { new Area(1) { Crevis = this }, new Area(2) { Crevis = this }, new Area(3) { Crevis = this }, new Area(4) { Crevis = this } };
        }
    }
}
