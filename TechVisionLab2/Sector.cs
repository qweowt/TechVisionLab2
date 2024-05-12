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
        public int CountWhite;
        public Cluster cluster;
        Bitmap image {  get; set; }
        public int X;
        public int Y;
        public Sector(Pixel[,] pixels, int x, int y, Bitmap img)
        {
            Pixels = pixels;
            CountWhite = ClusterCheck();
            X = x;
            Y = y;
            image = img;
            if ((float)CountWhite/100 >= 0.30)
                cluster = new Cluster(X, Y, pixels, image);

        }

        private int ClusterCheck()
        {
            int CountWhitePixels = 0;
            for (int i = 0; i < 10; i++)
                for (int j = 0; j < 10; j++)
                    if (Pixels[i, j].color == Color.FromArgb(255, 255, 255, 255))
                        CountWhitePixels++;

            return CountWhitePixels;
        }
    }
}
