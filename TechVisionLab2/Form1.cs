using Microsoft.VisualBasic.Logging;
using System.Diagnostics.Eventing.Reader;
using System.Net;
using System.Windows.Forms;

namespace TechVisionLab2
{
    public partial class Form1 : Form
    {
        Point StartPoint;
        Point EndPoint;
        Rectangle rect;
        Bitmap originalImage;
        Bitmap filteredImage;
        Sector[,] sectors = new Sector[10, 10];
        bool mask = false;
        int Rmin = 0;
        int Rmax = 255;
        int Gmin = 0;
        int Gmax = 255;
        int Bmin = 0;
        int Bmax = 255;

        double correctionCoefficient;
        int avg;
        int avgR;
        int avgG;
        int avgB;
        public Form1()
        {
            InitializeComponent();
        }

        private void PathSetButton_Click(object sender, EventArgs e)
        {
            ListView.Clear();
            string[] imageFiles = Directory.GetFiles(PathTb.Text);

            foreach (string imagePath in imageFiles)
            {
                ListViewItem item = new ListViewItem(Path.GetFileName(imagePath));
                item.Tag = imagePath;
                ListView.Items.Add(item);
            }
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListView.SelectedItems.Count > 0)
            {
                string selectedImagePath = ListView.SelectedItems[0].Tag.ToString();

                originalImage = new Bitmap(selectedImagePath);
                pictureBox1.Image = new Bitmap(originalImage);
                filteredImage = new Bitmap(selectedImagePath);

            }
        }

        private void PBMouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = e.Location;

            if (!PixelRead.Checked)
            {
                EndPoint = StartPoint;

                //using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                //    g.DrawRectangle(Pens.Red, StartPoint.X, StartPoint.Y, 1, 1);

                pictureBox1.Invalidate();
            }
        }

        private void PBMouseUp(object sender, MouseEventArgs e)
        {
            EndPoint = e.Location;

            if (!PixelRead.Checked)
            {
                int width = Math.Abs(EndPoint.X - StartPoint.X);
                int height = Math.Abs(EndPoint.Y - StartPoint.Y);

                rect = new Rectangle(Math.Min(StartPoint.X, EndPoint.X), Math.Min(StartPoint.Y, EndPoint.Y), width, height);
                pictureBox1.Invalidate();
                CalculateAverageColor();
                AvgLabel.Text = "AVG: " + Math.Round(correctionCoefficient, 4).ToString();
            }
        }

        private void CalculateAverageColor()
        {
            int totalR = 0, totalG = 0, totalB = 0;
            int count = 0;

            for (int x = rect.Left; x < rect.Right; x++)
            {
                for (int y = rect.Top; y < rect.Bottom; y++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);
                    totalR += pixelColor.R;
                    totalG += pixelColor.G;
                    totalB += pixelColor.B;
                    count++;
                }
            }

            avgR = totalR / count;
            avgG = totalG / count;
            avgB = totalB / count;
            avg = (avgR + avgG + avgB) / 3;

            correctionCoefficient = (avgR + avgG + avgB) / (3.0 * avgG);
        }

        private void PBMouseMove(object sender, MouseEventArgs e)
        {
            if (PixelRead.Checked)
            {
                if (originalImage != null)
                {
                    if (e.X >= 0 && e.X < originalImage.Width && e.Y >= 0 && e.Y < originalImage.Height)
                    {
                        Color pixelColor = originalImage.GetPixel(e.X, e.Y);
                        labelPixelColor.Text = $"RGB: ({pixelColor.R}, {pixelColor.G}, {pixelColor.B})";

                        Point offset = new Point(e.X + 10, e.Y + 10);
                        labelPixelColor.Location = offset;
                        labelPixelColor.Visible = true;
                    }
                    else
                    {
                        labelPixelColor.Visible = false;
                    }
                }
            }
            else
            {
                labelPixelColor.Visible = false;
            }
        }

        private void BlackMask_Click(object sender, EventArgs e)
        {
            if (mask == false)
            {
                if (RminTB.Text == null || RmaxTB.Text == null
                || GminTB.Text == null || GmaxTB.Text == null
                || BminTB.Text == null || BmaxTB.Text == null)
                {
                    MessageBox.Show("����������� �� �������");
                    return;
                }
                try
                {
                    Rmin = int.Parse(RminTB.Text);
                    Rmax = int.Parse(RmaxTB.Text);
                    Gmin = int.Parse(GminTB.Text);
                    Gmax = int.Parse(GmaxTB.Text);
                    Bmin = int.Parse(BminTB.Text);
                    Bmax = int.Parse(BmaxTB.Text);
                }
                catch
                {
                    MessageBox.Show("������ ������� �� �����");
                    return;
                }

                for (int x = 0; x < pictureBox1.Width; x++)
                {
                    for (int y = 0; y < pictureBox1.Height; y++)
                    {
                        Color pixelColor = originalImage.GetPixel(x, y);
                        if (pixelColor.R < Rmin || pixelColor.R > Rmax
                            || pixelColor.G < Gmin || pixelColor.G > Gmax
                            || pixelColor.B < Bmin || pixelColor.B > Bmax)
                        {
                            filteredImage.SetPixel(x, y, Color.FromArgb(255, 0, 0, 0));
                        }
                        else
                        {
                            filteredImage.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));
                        }
                    }
                    pictureBox1.Image = filteredImage;
                }
                mask = true;
            }
            else if (mask)
            {
                pictureBox1.Image = originalImage;
                mask = false;
            }
            //ClusterSearch();
        }

        private Bitmap ConvertToGrayscale(Bitmap originalImage)
        {
            Bitmap grayscaleImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);
                    int grayscaleValue = (int)(correctionCoefficient * pixelColor.R + correctionCoefficient * pixelColor.G + correctionCoefficient * pixelColor.B);
                    Color grayscaleColor = Color.FromArgb((int)(avg * pixelColor.R / avgR) < 255 ? (int)(avg * pixelColor.R / avgR) : 255,
                                                        (int)(avg * pixelColor.G / avgG) < 255 ? (int)(avg * pixelColor.G / avgG) : 255,
                                                        (int)(avg * pixelColor.B / avgB) < 255 ? (int)(avg * pixelColor.B / avgB) : 255);
                    grayscaleImage.SetPixel(x, y, grayscaleColor);
                }
            }

            return grayscaleImage;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.Image = ConvertToGrayscale(originalImage);
            else
                pictureBox1.Image = originalImage;
        }

        private void ClusterSearch()
        {
            
            pictureBox1.Image = filteredImage;
            for (int i = 0; i < filteredImage.Width; i+=10)
                for (int j = 0; j < filteredImage.Height; i+=10)
                    sectors[i, j] = new Sector(SectorCreate(i,j));

        }

        private void CompressImage(Bitmap originalImage, int iterations)
        {
            Bitmap processedImage = new Bitmap(originalImage.Width, originalImage.Height);
            Bitmap tmpImage = new Bitmap(originalImage.Width, originalImage.Height);

            // Erosion
            for (int i = 0; i < iterations; i++)
            {
                for (int x = 1; x < originalImage.Width - 1; x++)
                {
                    for (int y = 1; y < originalImage.Height - 1; y++)
                    {
                        if (originalImage.GetPixel(x, y) == Color.FromArgb(255, 0,0,0) ||
                            originalImage.GetPixel(x - 1, y) == Color.FromArgb(255, 0, 0, 0) ||
                            originalImage.GetPixel(x + 1, y) == Color.FromArgb(255, 0, 0, 0) ||
                            originalImage.GetPixel(x, y - 1) == Color.FromArgb(255, 0, 0, 0) ||
                            originalImage.GetPixel(x, y + 1) == Color.FromArgb(255, 0, 0, 0))
                        {
                            tmpImage.SetPixel(x, y, Color.FromArgb(255, 0, 0, 0));
                        }
                        else
                        {
                            tmpImage.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));
                        }
                    }
                }

                // Dilation
                for (int x = 1; x < originalImage.Width - 1; x++)
                {
                    for (int y = 1; y < originalImage.Height - 1; y++)
                    {
                        if (tmpImage.GetPixel(x, y) == Color.FromArgb(255, 255, 255, 255) ||
                            tmpImage.GetPixel(x - 1, y) == Color.FromArgb(255, 255, 255, 255) ||
                            tmpImage.GetPixel(x + 1, y) == Color.FromArgb(255, 255, 255, 255) ||
                            tmpImage.GetPixel(x, y - 1) == Color.FromArgb(255, 255, 255, 255) ||
                            tmpImage.GetPixel(x, y + 1) == Color.FromArgb(255, 255, 255, 255))
                        {
                            processedImage.SetPixel(x, y, Color.FromArgb(255, 255, 255, 255));
                        }
                        else
                        {
                            processedImage.SetPixel(x, y, Color.FromArgb(255, 0, 0, 0));
                        }
                    }
                }
            }

            pictureBox1.Image = processedImage;
        }

        private Pixel[,] SectorCreate(int X, int Y)
        {
            Pixel[,] list = new Pixel[40, 40];
            for (int x = X; x < 40; x++)
                for (int y = Y; y < 40; y++)
                    list[x, y] = new Pixel(X + x, Y + y, filteredImage.GetPixel(X + x, Y + y));
            return list;
        }

        private void Compress_Click(object sender, EventArgs e)
        {
            int iterations = 1;
            if (filteredImage != null)
            {
                CompressImage(filteredImage, iterations);
            }
            else
            {
                MessageBox.Show("Please load an image first.");
            }
        }
    }
}
