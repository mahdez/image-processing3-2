using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace image_processing3_2
{
    public partial class Form1 : Form
    {
        private Bitmap f_image = null;
        public Bitmap image;
        public Bitmap imageRed, imageGreen, imageBlue;  

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileImage = new OpenFileDialog();
            OpenFileImage.Filter = "bitmap(*.bmp) | *.bmp";
            OpenFileImage.FilterIndex = 1;
            if (OpenFileImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (f_image != null)
                        f_image.Dispose();
                    f_image =
                    (Bitmap)Bitmap.FromFile(OpenFileImage.FileName, false);

                }
                catch (Exception)
                {
                    MessageBox.Show("Can not open file", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            pictureBox1.Image = f_image;

            CreateHistogram();
            CreatePicture();
        }

        private void btn_Brightness_Click(object sender, EventArgs e)
        {
            image = new Bitmap(f_image.Width, f_image.Height);
            double percentage = Convert.ToDouble(Percentage.Text);
            int r, g, b;
            double percent;
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    Color PixelColor = f_image.GetPixel(i, j);
                    int R = (int)(PixelColor.R);
                    int G = (int)(PixelColor.G);
                    int B = (int)(PixelColor.B);
                    if (percentage > 0)
                    {
                        percent = percentage / 100;
                        r = (int)(R * percent + (1 - percent) + R);
                        g = (int)(G * percent + (1 - percent) + G);
                        b = (int)(B * percent + (1 - percent) + B);
                    }
                    else
                    {
                        percent = percentage / 100;
                        r = (int)(R * percent + R);
                        if (r > 255) r = 255;
                        g = (int)(G * percent + G);
                        if (g > 255) g = 255;
                        b = (int)(B * percent + B);
                    }

                    if (r > 255) r = 255;
                    if (g > 255) g = 255;
                    if (b > 255) b = 255;

                    image.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }

            pictureBox2.Image = image;
        }

        private void btn_Negative_Click(object sender, EventArgs e)
        {
            image = new Bitmap(f_image.Width, f_image.Height);
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    Color PixelColor = f_image.GetPixel(i, j);

                    image.SetPixel(i, j, Color.FromArgb(255 - PixelColor.R, 255 - PixelColor.G, 255 - PixelColor.B));

                }
            }

            pictureBox2.Image = image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void CreateHistogram()
        {
            int[] arrRed = new int[256];
            int[] arrGreen = new int[256];
            int[] arrBlue = new int[256];



            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    Color PixelColor = f_image.GetPixel(i, j);
                    arrRed[PixelColor.R]++;
                    arrGreen[PixelColor.G]++;
                    arrBlue[PixelColor.B]++;
                }
            }


            for (int i = 1; i < arrRed.Length; i++)
            {
                this.HistogramRed.Series["Color"].Points.AddXY(i, arrRed[i]);
                this.HistogramGreen.Series["Color"].Points.AddXY(i, arrGreen[i]);
                this.HistogramBlue.Series["Color"].Points.AddXY(i, arrBlue[i]);
            }


        }

        public void CreatePicture()
        {
            imageRed = new Bitmap(f_image.Width, f_image.Height);
            imageGreen = new Bitmap(f_image.Width, f_image.Height);
            imageBlue = new Bitmap(f_image.Width, f_image.Height);
            for (int i = 0; i < f_image.Width; i++)
            {
                for (int j = 0; j < f_image.Height; j++)
                {
                    Color PixelColor = f_image.GetPixel(i, j);
                    imageRed.SetPixel(i, j, Color.FromArgb(PixelColor.R, PixelColor.R, PixelColor.R));
                    imageGreen.SetPixel(i, j, Color.FromArgb(PixelColor.G, PixelColor.G, PixelColor.G));
                    imageBlue.SetPixel(i, j, Color.FromArgb(PixelColor.B, PixelColor.B, PixelColor.B));
                }
            }
            pictureBox3.Image = imageRed;
            pictureBox4.Image = imageGreen;
            pictureBox5.Image = imageBlue;
        }

    }


}

