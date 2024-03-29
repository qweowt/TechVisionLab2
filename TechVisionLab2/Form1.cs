using Microsoft.VisualBasic.Logging;
using System.Net;

namespace TechVisionLab2
{
    public partial class Form1 : Form
    {
        Point StartPoint;
        Point EndPoint;
        Rectangle rect;
        Bitmap originalImage;
        Bitmap filteredImage;

        int Rmin = 0;
        int Rmax = 255;
        int Gmin = 0;
        int Gmax = 255;
        int Bmin = 0;
        int Bmax = 255;
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
                pictureBox1.Image = originalImage;
                filteredImage = new Bitmap(originalImage);
            }
        }

        private void PBMouseDown(object sender, MouseEventArgs e)
        {
            StartPoint = e.Location;

            if (!PixelRead.Checked)
            {
                EndPoint = StartPoint;

                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                    g.DrawRectangle(Pens.Red, StartPoint.X, StartPoint.Y, 1, 1);

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

                using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                {
                    g.DrawRectangle(Pens.Red, rect);
                }

                pictureBox1.Invalidate();

                CalculateAverageColor();
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

            int avgR = totalR / count;
            int avgG = totalG / count;
            int avgB = totalB / count;

            double correctionCoefficient = (avgR + avgG + avgB) / (3.0 * avgG);
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
                        filteredImage.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
                    }
                }
            }
        }

        private Bitmap ConvertToGrayscale(Bitmap originalImage)
        {
            Bitmap grayscaleImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int x = 0; x < originalImage.Width; x++)
            {
                for (int y = 0; y < originalImage.Height; y++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);
                    int grayscaleValue = (int)(0.299 * pixelColor.R + 0.587 * pixelColor.G + 0.114 * pixelColor.B);
                    Color grayscaleColor = Color.FromArgb(grayscaleValue, grayscaleValue, grayscaleValue);
                    grayscaleImage.SetPixel(x, y, grayscaleColor);
                }
            }

            return grayscaleImage;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                pictureBox1.Image = filteredImage;
            else
                pictureBox1.Image = originalImage;
        }
    }
}
