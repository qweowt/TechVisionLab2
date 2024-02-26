using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechVisionLab2
{
    public class Pixel
    {
        public int X {  get; set; }
        public int Y {  get; set; }

        public Color color { get; set; }

        public Pixel(int x, int y, Color clr)
        {
            X = x;
            Y = y;
            color = clr;
        }
    }
}
