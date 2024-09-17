using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    using FastBitmap;
    public partial class Form2 : Form
    {
        private Graphics g;
        private int bitmapWidth;
        private int bitmapHeight;
        private string path = "../../image/ФРУКТЫ.jpg";
        public Form2()
        {
            InitializeComponent();
            g = MainPanel.CreateGraphics();
        }

        /*Выделить из полноцветного изображения каждый из каналов R, G, B  
          и вывести результат. Построить гистограмму по цветам (3 штуки).*/
        private void Button_Task2_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Bitmap bm_og = new Bitmap(path);
            bitmapWidth = bm_og.Width / 3;
            bitmapHeight = bm_og.Height / 3;
            Bitmap bm = new Bitmap(bm_og, bitmapWidth, bitmapHeight);
            Bitmap bm_r = new Bitmap(bm);
            Bitmap bm_g = new Bitmap(bm);
            Bitmap bm_b = new Bitmap(bm);
            g.DrawImage(bm, bitmapWidth - 60, 20);

            //Массивы для гистограммы
            int[] red = new int[256];
            int[] green = new int[256];
            int[] blue = new int[256];

            using (var fbm_r = new FastBitmap(bm_r))
            using (var fbm_g = new FastBitmap(bm_g))
            using (var fbm_b = new FastBitmap(bm_b))
            {
                for (var x = 0; x < fbm_b.Width; x++)
                    for (var y = 0; y < fbm_b.Height; y++)
                    {
                        var color = fbm_b[x, y];
                        fbm_r[x, y] = Color.FromArgb(color.R, 0, 0);
                        fbm_g[x, y] = Color.FromArgb(0, color.G, 0);
                        fbm_b[x, y] = Color.FromArgb(0, 0, color.B);

                        red[color.R]++;
                        green[color.G]++;
                        blue[color.B]++;
                    }
            }

            g.DrawImage(bm_r, bitmapWidth + 220, 20);
            g.DrawImage(bm_g, bitmapWidth - 60, bitmapHeight + 40);
            g.DrawImage(bm_b, bitmapWidth + 220, bitmapHeight + 40);

            Pen rPen = new Pen(Color.Red, 1.5f);
            Pen gPen = new Pen(Color.Green, 1.4f);
            Pen bPen = new Pen(Color.Blue, 1.4f);

            List<PointF> rHist = new List<PointF>();
            List<PointF> gHist = new List<PointF>();
            List<PointF> bHist = new List<PointF>();

            for (int i = 0; i < 256;  i++)
            {
                red[i] /= 5;
                green[i] /= 5;
                blue[i] /= 5;
            }

            for (int i = 0; i < 256; i++)
            {
                rHist.Add(new PointF(20 + i * 3.4f, MainPanel.Height - red[i] - 20));
                gHist.Add(new PointF(20 + i * 3.4f, MainPanel.Height - green[i] - 20));
                bHist.Add(new PointF(20 + i * 3.4f, MainPanel.Height - blue[i] - 20));
            }

            g.DrawLines(rPen, rHist.ToArray());
            g.DrawLines(gPen, gHist.ToArray());
            g.DrawLines(bPen, bHist.ToArray());
        }
    }
}
