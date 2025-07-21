using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simargl
{
    internal class Utils
    {
        public static string GetStringForTime(uint time)
        {
            return $"{(time % 86400 / 3600).ToString().PadLeft(2, '0')}:{(time % 3600 / 60).ToString().PadLeft(2, '0')}:{(time % 60).ToString().PadLeft(2, '0')}";
        }
    }
}
