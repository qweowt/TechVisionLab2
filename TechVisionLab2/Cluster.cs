using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechVisionLab2
{
    public class Cluster
    {
        public int X {  get; set; }
        public int Y {  get; set; }
        public int CountWhite = 0;
        public Bitmap image { get; set; }
        public int size { get; set; }
        public Pixel[,] Pixels { get; set; }
        public int Wmax { get; set; }
        public int Hmax { get; set; }

        public Cluster(int x, int y, Pixel[,] pixels, Bitmap img)
        {
            X = x;
            Y = y;
            Pixels = pixels;
            image = img;
            size = 10;
            CountWhite = ClusterCheck();
            while ((float)(CountWhite) / (float)(size*size) >= 0.3)
                growing();
        }

        public void growing()
        {
            Pixels = ArrayGrowing(Pixels);
            CountWhite = ClusterCheck();
        }

        private int ClusterCheck()
        {
            int CountWhitePixels = 0;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    if (Pixels[i, j].color == Color.FromArgb(255, 255, 255, 255))
                        CountWhitePixels++;

            return CountWhitePixels;
        }

        private Pixel[,] ArrayGrowing(Pixel[,] pixels)
        {
            size += 10;
            Pixel[,] newPixels = new Pixel[size, size];
            for (int i = X-5, x = 0; x < size; i++, x++)
                for (int j = Y-5, y = 0; y < size; j++, y++)
                    if (i > 0 && i < 399 && j > 0 && j < 399)
                        newPixels[x, y] = new Pixel(i, j, image.GetPixel(i, j));

            return newPixels;
        }

        public void SizeSearch()
        {
            Wmax = X + 10;
            Hmax = Y + 10;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    if (Pixels[i, j].color == Color.FromArgb(255,255,255,255))
                        if(Wmax < Pixels[i,j].X)
                            Wmax = Pixels[i,j].X;

            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    if (Pixels[i, j].color == Color.FromArgb(255, 255, 255, 255))
                        if (Hmax < Pixels[i, j].Y)
                            Hmax = Pixels[i, j].Y;
        }
    }
}
