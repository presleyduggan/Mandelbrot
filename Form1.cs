using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandelbrot
{
    public partial class Form1 : Form
    {
        int zoom;
        int zoomAdd;
        Complex offset = new Complex(0, 0);


        public Form1()
        {
            InitializeComponent();
        }

        public bool IsMouseDown { get; private set; }
        public object InterpolationMode { get; private set; }

        public void Form1_Shown(object sender, EventArgs e)
        {
            zoom = 1;
            zoomAdd = 1;
            currentZoom.Text = "Current Zoom = " + zoom + "x";
            
                Bitmap bm = new Bitmap(picCanvas.Width, picCanvas.Height);
                for (int x = 0; x < picCanvas.Width; x++)
                {
                    for (int y = 0; y < picCanvas.Height; y++)
                    {

                        double a = (double)(x - (picCanvas.Width / 2)) / (double)(picCanvas.Width / 4);
                        double b = (double)(y - (picCanvas.Height / 2)) / (double)(picCanvas.Height / 4);
                        Complex c0 = new Complex(a, b);
                        Complex z = new Complex(0, 0);
                        int it = 0;
                        do
                        {
                            it++;
                            z.Square();
                            z.Add(c0);
                            if (z.Magnitude() > 2.0) break;
                        }
                        while (it < 129);
                        bm.SetPixel(x, y, Color.FromArgb(it % 128 * 2, it % 64 * 4, it % 32 * 8));
                        //btm.SetPixel(x, y, Color.FromArgb(iter % 128 * 2, iter % 64 * 4, iter % 32 * 8));

                    }

                    picCanvas.Image = bm;
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zoom = 1;
            zoomText.Text = "1";
            currentZoom.Text = "Current Zoom = " + zoom + "x";
            offset = new Complex(0, 0);
            Bitmap bm = new Bitmap(picCanvas.Width, picCanvas.Height);
            for (int x = 0; x < picCanvas.Width; x++)
            {
                for (int y = 0; y < picCanvas.Height; y++)
                {

                    double a = (double)(x - (picCanvas.Width / 2)) / (double)(picCanvas.Width / 4);
                    double b = (double)(y - (picCanvas.Height / 2)) / (double)(picCanvas.Height / 4);
                    Complex c0 = new Complex(a, b);
                    Complex z = new Complex(0, 0);
                    int it = 0;
                    do
                    {
                        it++;
                        z.Square();
                        z.Add(c0);
                        if (z.Magnitude() > 2.0) break;
                    }
                    while (it < 129);
                    bm.SetPixel(x, y, Color.FromArgb(it % 128 * 2, it % 64 * 4, it % 32 * 8));

                }

                picCanvas.Image = bm;
            }
        }

        private void zoomer(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                double Mouse_X = e.X;
                double Mouse_Y = e.Y;
                System.Diagnostics.Debug.WriteLine(e.X);
                System.Diagnostics.Debug.WriteLine(e.Y);

            }
        }

        private void picCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void picCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            double Mouse_X = e.X;
            double Mouse_Y = e.Y;
            double c;
            double d;
            
            c = (double)(Mouse_X - (picCanvas.Width / 2)) / (double)(picCanvas.Width / 4*zoom);
            d = (double)(Mouse_Y - (picCanvas.Height / 2)) / (double)(picCanvas.Height / 4*zoom);
            
            

            zoom = zoom + zoomAdd;
            currentZoom.Text = "Current Zoom = " + zoom + "x";
            Complex offset1 = new Complex(c, d);
            offset.Add(offset1);
            System.Diagnostics.Debug.WriteLine(c);
            System.Diagnostics.Debug.WriteLine(d);
            //newCX = (float)Mouse_X;
            //newCY = (float)Mouse_Y;

           // picCanvas.Refresh();
            

            Bitmap bm = new Bitmap(picCanvas.Width, picCanvas.Height);

            for (int x = 0; x < picCanvas.Width; x++)
            {
                for (int y = 0; y < picCanvas.Height; y++)
                {
                    double a = (double)(x - ((picCanvas.Width) / 2)) / (double)((picCanvas.Width) / 4*zoom);
                    double b = (double)(y - ((picCanvas.Width) / 2)) / (double)((picCanvas.Width) / 4*zoom);
                    Complex c0 = new Complex(a, b);
                    c0.Add(offset);
                    Complex z = new Complex(0, 0);
                    int it = 0;
                    do
                    {
                        it++;
                        z.Square();
                        z.Add(c0);
                        if (z.Magnitude() > 2.0) break;
                    }
                    while (it < 129);
                    bm.SetPixel(x, y, Color.FromArgb(it % 128 * 2, it % 64 * 4, it % 32 * 8));

                }

                picCanvas.Image = bm;


            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberFormatInfo formatProvider = new NumberFormatInfo();
            formatProvider.NumberDecimalSeparator = ".";
            zoomAdd = Convert.ToInt32(zoomText.Text, formatProvider);
            if(zoomAdd < 1)
            {
                zoomAdd = 1;
                zoomText.Text = "1";
            }
        }
    }
}
