using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Simargl.Device
{
    internal class Level : ITreeDisplayed
    {
        public string Name { get; }
        public Bitmap? StateIcon { get; private set; }
        public string StateText { get; private set; }

        public Level(string name)
        {
            Name = name;
            AddParam("Level", "mm");
            // Initialize StateIcon and StateText with default values  
            StateIcon = null;
            StateText = string.Empty;
        }

        public Dictionary<string, Param> Params { get; } = new Dictionary<string, Param>();
        public void AddParam(string name, string unit)
        {
            if (!Params.ContainsKey(name))
            {
                Params.Add(name, new Param(name, unit));
            }
        }
    }
}
