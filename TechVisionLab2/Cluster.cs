using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechVisionLab2
{
    public class Cluster
    {
        public int cX {  get; set; }
        public int cY {  get; set; }
        public int size {  get; set; }

        public Cluster(int cx, int cy, int s)
        {
            cX = cx;
            cY = cy;
            size = s;
        }
    }
}
