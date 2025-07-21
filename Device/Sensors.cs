using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.Device
{
    internal class Sensors : ITreeDisplayed
    {
        public string Name => "Sensors";
        public Bitmap? StateIcon => null;
        public string StateText => string.Empty;
        public Dictionary<string, Sensor> List { get; } = new Dictionary<string, Sensor>();
        public void Add(string name, enSensorType type)
        {
            if (!List.ContainsKey(name))
                    List.Add(name, new Sensor(name, type));
        }
    }
}
