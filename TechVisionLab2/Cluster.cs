using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechVisionLab2
{
    public class Sector
    {
        public Pixel[,] Pixels {  get; set; }
        public bool HasWhite {  get; set; }
        public int CountWhite;

        public Sector(Pixel[,] pixels)
        {
            Pixels = pixels;
            HasWhite = ClusterCheck(); 
        }

        private bool ClusterCheck()
        {
            int CountWhitePixels = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Pixels[i, j].color == Color.FromArgb(255, 255, 255, 255))
                    {
                        CountWhitePixels++;
                    }
                }
            }
            CountWhite = CountWhitePixels;
            if (CountWhitePixels > 0)
                return true;
            else
                return false;
            
        }
    }
}
