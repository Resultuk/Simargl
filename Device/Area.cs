using Simargl.HorticultureModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.Device
{
    internal class Area : ITreeDisplayed
    {
        private int number;
        public Area(int number)
        {
            this.number = number;
        }
        public Crevis Crevis { get; set; }
        public string Name => $"Area #{number}";
        public int Number => number;
        public AgroRecipe AgroRecipe { get; set; } = new AgroRecipe();
        public WaterClass WaterClass { get; set; } = new WaterClass();
        public SubDevIDs SubDevIDs { get; set; } = new SubDevIDs();
    }
}
