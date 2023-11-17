using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace image_processing2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap pict_O, pict_C;

        public Bitmap ConvertToGrey1(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int avg = (int)((c.R + c.G + c.B) / 3);
                    bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));

                }
            }
            return bmp;
        }




        public Bitmap ConvertToGrey2(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int avg = (int)(0.3 * c.R + 0.59 * c.G + 0.11 * c.B);
                    bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));

                }
            }
            return bmp;
        }
        public Bitmap Thresholding1(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int t = int.Parse(textBox1.Text);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int avg = (int)((c.R + c.G + c.B) / 3);
                    if (avg > t)
                        avg = 255;
                    else avg = 0;

                    bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            return bmp;
        }

        public Bitmap Invert(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int t = int.Parse(textBox1.Text);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int avg = (int)((c.R + c.G + c.B) / 3);
                    if (avg == 255)
                        avg = 0;
                    else if (avg == 0)
                        avg = 255;

                    bmp.SetPixel(i, j, Color.FromArgb(avg, avg, avg));
                }
            }
            return bmp;
        }

        public Bitmap Negative(Bitmap source)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);
            int t = int.Parse(textBox1.Text);

            for (int i = 0; i < source.Width; i++)
            {
                for (int j = 0; j < source.Height; j++)
                {
                    Color c = source.GetPixel(i, j);
                    int r1, g1, b1;
                    r1 = 255 - (int)(c.R);
                    g1 = 255 - (int)(c.G);
                    b1 = 255 - (int)(c.B);
                    bmp.SetPixel(i, j, Color.FromArgb(r1, g1, b1));
                }
            }
            return bmp;
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = pict_O;
            pictureBox1.Refresh();


        }

        private void btnGrey1_Click(object sender, EventArgs e)
        {
            pict_C = ConvertToGrey1(pict_O);
            pictureBox1.Image = pict_C;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pict_O = new Bitmap(opf.FileName);
                pict_C = pict_O;
                pictureBox1.Image = pict_O;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGrey2_Click(object sender, EventArgs e)
        {
            pict_C = ConvertToGrey2(pict_O);
            pictureBox1.Image = pict_C;
        }

        private void btnBW_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = Thresholding1(pict_C);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = Invert(pict_C);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            pict_C = new Bitmap(pictureBox1.Image);
            pictureBox1.Image = Negative(pict_O);

        }

        private void btnLogtransformations_Click(object sender, EventArgs e)
        {

        }
    }
}
