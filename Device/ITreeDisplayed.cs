using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl.Device
{
    internal interface ITreeDisplayed
    {
        public string Name { get; }
        public Bitmap? StateIcon { get; }
        public string StateText { get; }
    }
}
