using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.Device
{
    public class Sensor : ITreeDisplayed
    {
        public enSensorType Type { get; }
        public Sensor(string name, enSensorType type = enSensorType.S4)
        {
            Name = name;
            Type = type;
            switch (type)
            {
                case enSensorType.S4:
                    AddParam("T", "°С");
                    AddParam("RH", "%");
                    AddParam("P", "mmHg");
                    AddParam("CO2", "ppm");
                    break;
                case enSensorType.GR500:
                    AddParam("Tpcb", "°С");
                    AddParam("Load", "");
                    break;
                case enSensorType.Level:
                    AddParam("Level", "mm");
                    break;
            }
        }
        public string Name { get; }
        public Bitmap? StateIcon => null;
        public string StateText => string.Empty;
        public Dictionary<string, Param> Params { get; } = new Dictionary<string, Param>();
        public void AddParam(string name, string unit)
        {
            if (!Params.ContainsKey(name))
            {
                Params.Add(name, new Param(name, unit));
            }
        }
    }
    public enum enSensorType
    {
        S4,
        GR500,
        Level
    }
}