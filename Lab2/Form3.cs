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
    using System.Diagnostics;
    using static System.Windows.Forms.AxHost;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    public partial class Form3 : Form
    {

        Graphics _graphics;
        Bitmap bitmap;
        private int _BitmapWidth;
        private int _BitmapHeight;
        private string _path_to_image = "../../image/ФРУКТЫ.jpg";

        private int H = 180;
        private int S = 50;
        private int V = 50;

        public Form3()
        {
            InitializeComponent();
            _graphics = MainPanel.CreateGraphics();
        }

        double[,] H_bm;
        double[,] S_bm;
        double[,] V_bm;

        private void Button_Task3_Click(object sender, EventArgs e)
        {
            //Начальная отрисовка изображения
            _graphics.Clear(Color.White);
            bitmap = new Bitmap(_path_to_image);
            _BitmapWidth = bitmap.Width;
            _BitmapHeight = bitmap.Height;
            bitmap = new Bitmap(bitmap, _BitmapWidth, _BitmapHeight);
            _graphics.DrawImage(bitmap, (MainPanel.Height - _BitmapHeight) / 2, (MainPanel.Width - _BitmapWidth) / 2);

            H_bm = new double[_BitmapWidth, _BitmapHeight];
            S_bm = new double[_BitmapWidth, _BitmapHeight];
            V_bm = new double[_BitmapWidth, _BitmapHeight];

            RGB_To_HSV(bitmap);
        }

        private void RGB_To_HSV(Bitmap bitmap)
        {
            using (var fastBitmap = new FastBitmap(bitmap))
                for (var x = 0; x < fastBitmap.Width; x++)
                for (var y = 0; y < fastBitmap.Height; y++)
                {
                        var color = fastBitmap[x, y];
                        int max = Math.Max(color.R, Math.Max(color.G, color.B));
                        int min = Math.Min(color.R, Math.Min(color.G, color.B));

                        if (max == 0) { S_bm[x, y] = 0; }
                        else { S_bm[x, y] = 1d - min / max; }

                        V_bm[x, y] = max / 255d;

                        if (max == min) { H_bm[x, y] = 0; continue; }
                        if (max == color.R && color.G >= color.B) {H_bm[x, y] = 60 * (color.G - color.B) / (max - min); continue; }
                        if (max == color.R && color.G < color.B) { H_bm[x, y] = 60 * (color.G - color.B) / (max - min) + 360; continue; }
                        if (max == color.G) { H_bm[x, y] = 60 * (color.B - color.R) / (max - min) + 120; }
                        if (max == color.B) { H_bm[x, y] = 60 * (color.R - color.G) / (max - min) + 240; }

                }
        }

        private void HSV_To_RGB(Bitmap bitmap)
        {

            using (var fastBitmap = new FastBitmap(bitmap))
            {
                for (var x = 0; x < fastBitmap.Width; x++)
                    for (var y = 0; y < fastBitmap.Height; y++)
                    {
                        int hi = Convert.ToInt32(Math.Floor(H_bm[x, y] / 60.0)) % 6;
                        double f = H_bm[x, y] / 60d - Math.Floor(H_bm[x, y] / 60.0);

                        double value = V_bm[x,y] * 255d;
                        int v = Convert.ToInt32(value);
                        int p = Convert.ToInt32(value * (1d - S_bm[x, y]));
                        int q = Convert.ToInt32(value * (1d - f * S_bm[x, y]));
                        int t = Convert.ToInt32(value * (1d - (1d - f) * S_bm[x, y]));


                        if (hi == 0)
                            fastBitmap[x, y] = Color.FromArgb(v, t, p);
                        else if (hi == 1)
                            fastBitmap[x, y] = Color.FromArgb(q, v, p);
                        else if (hi == 2)
                            fastBitmap[x, y] = Color.FromArgb(p, v, t);
                        else if (hi == 3)
                            fastBitmap[x, y] = Color.FromArgb(p, q, v);
                        else if (hi == 4)
                            fastBitmap[x, y] = Color.FromArgb(t, p, v);
                        else
                            fastBitmap[x, y] = Color.FromArgb(v, p, q);
                    }   
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            HSV_To_RGB(bitmap);
            bitmap.Save("../../image/result.jpg");
        }

        private void V_trackBar_Scroll(object sender, EventArgs e)
        {
            double delta = (V_trackBar.Value - V) / 100d;
            for (int x = 0; x < V_bm.GetLength(0); x++)
                for (int y = 0; y < V_bm.GetLength(1); y++)
                {
                    V_bm[x, y] = Math.Min(1, Math.Max(V_bm[x, y] + delta, 0));
                }
            V = V_trackBar.Value;

            //_graphics.Clear(Color.White);
            HSV_To_RGB(bitmap);
            _graphics.DrawImage(bitmap, (MainPanel.Height - _BitmapHeight) / 2, (MainPanel.Width - _BitmapWidth) / 2);
        }

        private void H_trackBar_Scroll(object sender, EventArgs e)
        {
            int delta = H_trackBar.Value - H;
            for (int x = 0; x < _BitmapWidth; x++)
                for (int y = 0; y < _BitmapHeight; y++)
                {
                    H_bm[x, y] = (H_bm[x, y] + delta < 360) ? H_bm[x, y] + delta : H_bm[x, y] + delta - 360;
                }
            H = H_trackBar.Value;

            //_graphics.Clear(Color.White);
            HSV_To_RGB(bitmap);
            _graphics.DrawImage(bitmap, (MainPanel.Height - _BitmapHeight) / 2, (MainPanel.Width - _BitmapWidth) / 2);
        }

        private void S_trackBar_Scroll(object sender, EventArgs e)
        {
            double delta = (S_trackBar.Value - S) / 100d;
            for (int x = 0; x < S_bm.GetLength(0); x++)
                for (int y = 0; y < S_bm.GetLength(1); y++)
                {
                    S_bm[x, y] = Math.Min(1, Math.Max(S_bm[x, y] + delta, 0d));
                }
            S = S_trackBar.Value;

            //_graphics.Clear(Color.White);
            HSV_To_RGB(bitmap);
            _graphics.DrawImage(bitmap, (MainPanel.Height - _BitmapHeight) / 2, (MainPanel.Width - _BitmapWidth) / 2);
        }
    }
}
