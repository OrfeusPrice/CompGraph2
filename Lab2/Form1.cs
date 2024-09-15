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
    /*MainPanel - Основная панель, на которой будет отображаться рисунок
      H_trackBar - ползунок для Hue
      S_trackBar - ползунок для Saturation
      V_trackBar - ползунок для Value
      SaveButton - Кнопка сохранения картинки для Task3
     */
    public partial class Form1 : Form
    {
        //Перечисление, чтобы ползунки и сохранение работало только в случае исполнения 3 задания
        enum TaskInProcess { NoTask3, Task3 };
        TaskInProcess _curTask = TaskInProcess.NoTask3;
        /// <summary>
        /// Элемент управления отрисовкой на MainPanel
        /// </summary>
        Graphics _graphics;
        private int _BitmapWidth;
        private int _BitmapHeight;
        private string _path_to_image = "../../image/ФРУКТЫ.jpg";

        public Form1()
        {
            InitializeComponent();
            _graphics = MainPanel.CreateGraphics();
        }

        private void Draw4Images(Graphics g, Bitmap b1, Bitmap b2, Bitmap b3, Bitmap b4)
        {
            _graphics.DrawImage(b1, -150 + _BitmapWidth, 20);
            _graphics.DrawImage(b2, -150 + _BitmapWidth * 2 + 10, 20);
            _graphics.DrawImage(b3, -150 + _BitmapWidth, _BitmapHeight + 30);
            _graphics.DrawImage(b4, -150 + _BitmapWidth * 2 + 10, _BitmapHeight + 30);
        }

        //1) Преобразовать изображение из RGB в оттенки серого.
        //Реализовать два варианта формулы с учетом разных вкладов R, G и B в интенсивность (см презентацию).
        //Затем найти разность полученных полутоновых изображений.
        //Построить гистограммы интенсивности после одного и второго преобразования.
        private void Button_Task1_Click(object sender, EventArgs e)
        {
            _curTask = TaskInProcess.NoTask3;
            ClearPanel();
            Bitmap bitmap = new Bitmap(_path_to_image);
            _BitmapWidth = bitmap.Width / 3;
            _BitmapHeight = bitmap.Height / 3;
            bitmap = new Bitmap(bitmap, _BitmapWidth, _BitmapHeight);
            Bitmap bitmap1 = new Bitmap(bitmap, _BitmapWidth, _BitmapHeight);
            Bitmap bitmap2 = new Bitmap(bitmap, _BitmapWidth, _BitmapHeight);
            Bitmap BMdiff = new Bitmap(_BitmapWidth, _BitmapHeight);
            Bitmap gist = new Bitmap(_BitmapWidth * 3, _BitmapHeight);

            int[] I1 = new int[256];
            int[] I2 = new int[256];

            using (var FB_1 = new FastBitmap(bitmap1))
            using (var FB_2 = new FastBitmap(bitmap2))
            using (var FB_diff = new FastBitmap(BMdiff))
            {
                Point px;
                Color color, diffColor;
                int gray1, gray2, diff;
                for (int x = 0; x < FB_1.Width; x++)
                {
                    for (int y = 0; y < FB_1.Height; y++)
                    {
                        px = new Point(x, y);
                        color = FB_1.GetPixel(px);

                        gray1 = (int)(color.R * 0.299 + color.G * 0.587 + color.B * 0.114);
                        gray2 = (int)(color.R * 0.2126 + color.G * 0.7152 + color.B * 0.0722);

                        I1[gray1]++;
                        I2[gray2]++;

                        FB_1.SetPixel(px, Color.FromArgb(gray1, gray1, gray1));
                        FB_2.SetPixel(px, Color.FromArgb(gray2, gray2, gray2));

                        diff = Math.Abs(gray1 - gray2);
                        diffColor = Color.FromArgb(diff, diff, diff);
                        FB_diff.SetPixel(px, diffColor);
                    }
                }
            }
            Draw4Images(_graphics, bitmap, bitmap1, bitmap2, BMdiff);

            int max = Math.Max(I1.Max(), I2.Max());
            double scale = 1.0 * max / bitmap.Height;

            for (int i = 0; i < bitmap.Width - 3; i++)
            {
                for (int j = bitmap.Height - 1; j > bitmap.Height - I1[i / 3] / scale; j--)
                {
                    gist.SetPixel(i * 3, j, Color.Red);
                    gist.SetPixel(i * 3 + 1, j, Color.Red);
                    gist.SetPixel(i * 3 + 2, j, Color.Red);
                }
                i++;
                for (int j = bitmap.Height - 1; j > bitmap.Height - I2[i / 3] / scale; j--)
                {
                    gist.SetPixel(i * 3, j, Color.Blue);
                    gist.SetPixel(i * 3 + 1, j, Color.Blue);
                    gist.SetPixel(i * 3 + 2, j, Color.Blue);
                }
                i++;
            }

            _graphics.DrawImage(gist, 0, 2.5f * bitmap.Height);
        }

        private void Button_Task2_Click(object sender, EventArgs e)
        {
            _curTask = TaskInProcess.NoTask3;
            ClearPanel();
            //ToDo Task2 (KsevenCh)
        }

        private void Button_Task3_Click(object sender, EventArgs e)
        {
            _curTask = TaskInProcess.Task3;
            ClearPanel();
            //ToDo Task3 (Xienn)
        }

        private void H_trackBar_Scroll(object sender, EventArgs e)
        {
            //ToDo Hue (Xienn)
        }

        private void S_trackBar_Scroll(object sender, EventArgs e)
        {
            //ToDo Saturation (Xienn)
        }

        private void V_trackBar_Scroll(object sender, EventArgs e)
        {
            //ToDo V (Value?) (Xienn)
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (_curTask == TaskInProcess.Task3)
            {
                //ToDo сохранение для 3 задания (Xienn)
            }
        }

        private void ClearPanel()
        {
            _graphics.Clear(Color.White);
        }
    }
}
