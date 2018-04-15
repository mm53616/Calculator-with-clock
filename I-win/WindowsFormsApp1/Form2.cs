using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int szer = 300, wys = 300, wskazSek = 140, wskazMin = 140, wskazGodz = 80;
        int srodekX, srodekY;

        Bitmap bmp;
        Graphics g;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //tworzenie bitmapy
            bmp = new Bitmap(szer + 1, wys + 1);

            //polozenie srodka
            srodekX = szer / 2;
            srodekY = wys / 2;

            //     t.Tick += new EventHandler(this.t_Tick);
            timer2.Start();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            //tworzenie grafiki
            g = Graphics.FromImage(bmp);

            //pobieranie czasu
            int sekundy = DateTime.Now.Second;
            int minuty = DateTime.Now.Minute;
            int godziny = DateTime.Now.Hour;

            int[] wskazowka_wspolrzedne = new int[2];

            //czyszczenie obrazu
            g.Clear(Color.White);

            //rysowanie tarczy
            g.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, szer, wys);
            g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
            g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
            g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
            g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

            //wskazowki
            wskazowka_wspolrzedne = min_sek_wspolrzedne(sekundy, wskazSek);
            g.DrawLine(new Pen(Color.Red, 1f), new Point(srodekX, srodekY), new Point(wskazowka_wspolrzedne[0], wskazowka_wspolrzedne[1]));

            wskazowka_wspolrzedne = min_sek_wspolrzedne(minuty, wskazMin);
            g.DrawLine(new Pen(Color.Black, 2f), new Point(srodekX, srodekY), new Point(wskazowka_wspolrzedne[0], wskazowka_wspolrzedne[1]));

            wskazowka_wspolrzedne = godz_wspolrzedne(godziny % 12, minuty, wskazGodz);
            g.DrawLine(new Pen(Color.Blue, 3f), new Point(srodekX, srodekY), new Point(wskazowka_wspolrzedne[0], wskazowka_wspolrzedne[1]));

            pictureBox1.Image = bmp; //zaladowanie grafiki w picturebox1
            this.Text = "Zegar Analogowy -  " + godziny + ":" + minuty + ":" + sekundy;
            g.Dispose();
        }
        //wspolrzedne dla minut i sekund
        private int[] min_sek_wspolrzedne(int wartosc, int dlug_godz)
        {
            int[] wspolrzedne = new int[2];
            wartosc *= 6;   //minuty i sekundy robia 6*

            if (wartosc >= 0 && wartosc <= 180)
            {
                wspolrzedne[0] = srodekX + (int)(dlug_godz * Math.Sin(Math.PI * wartosc / 180));
                wspolrzedne[1] = srodekY - (int)(dlug_godz * Math.Cos(Math.PI * wartosc / 180));
            }
            else
            {
                wspolrzedne[0] = srodekX - (int)(dlug_godz * -Math.Sin(Math.PI * wartosc / 180));
                wspolrzedne[1] = srodekY - (int)(dlug_godz * Math.Cos(Math.PI * wartosc / 180));
            }
            return wspolrzedne;
        }

        //wspolrzedne dla wskazowki godz
        private int[] godz_wspolrzedne(int godz_wartosc, int min_wartosc, int dlug_godz)
        {
            int[] wspolrzedne = new int[2];

            // kazda godzina 30* a kazda minuta 0.5*
            int wartosc = (int)((godz_wartosc * 30) + (min_wartosc * 0.5));

            if (wartosc >= 0 && wartosc <= 180)
            {
                wspolrzedne[0] = srodekX + (int)(dlug_godz * Math.Sin(Math.PI * wartosc / 180));
                wspolrzedne[1] = srodekY - (int)(dlug_godz * Math.Cos(Math.PI * wartosc / 180));
            }
            else
            {
                wspolrzedne[0] = srodekX - (int)(dlug_godz * -Math.Sin(Math.PI * wartosc / 180));
                wspolrzedne[1] = srodekY - (int)(dlug_godz * Math.Cos(Math.PI * wartosc / 180));
            }
            return wspolrzedne;
        }
    }
}
