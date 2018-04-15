using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp1
{
     public partial class Form1 : Form
    {
        double wartosc = 0; // wynik koncowy
        string wybor; // wybieramy które dzialanie chcemy wykonac
        bool wybrany = false; // sprawdzamy czy przycisk zostal wcisniety

        public Form1()
        {
            InitializeComponent();
        }

        private void b_Click(object sender, EventArgs e)
        {
            if ((tbWynik.Text == "0") || (wybrany))
                tbWynik.Clear();
            wybrany = false;
            Button b = (Button)sender;
            if (b.Text == ",")
            {
                if (!tbWynik.Text.Contains(","))
                    tbWynik.Text = tbWynik.Text + b.Text;
            }
            else
                tbWynik.Text = tbWynik.Text + b.Text;
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            tbWynik.Text = "0";
        }

        private void bDzialanie_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            wybor = b.Text;
            wartosc = Double.Parse(tbWynik.Text);//parsujemy strnig na double
            wybrany = true;
            CoMamy.Text = wartosc + " " + wybor;

        }

        private void bRownaSie_Click(object sender, EventArgs e)
        {
            CoMamy.Text = " ";
            switch (wybor)
            {
                case "+":
                    tbWynik.Text = (wartosc + Double.Parse(tbWynik.Text)).ToString();
                    break;
                case "-":
                    tbWynik.Text = (wartosc - Double.Parse(tbWynik.Text)).ToString();
                    break;
                case "*":
                    tbWynik.Text = (wartosc * Double.Parse(tbWynik.Text)).ToString();
                    break;
                case "/":
                     if (tbWynik.Text == "0")
                     {
                        tbWynik.Text = "Nie dzieli sie przez 0";
                        tbWynik.Clear();
                     }
                     else
                       tbWynik.Text = (wartosc / Double.Parse(tbWynik.Text)).ToString();
                    break;
                default:
                    break;
            }
            /*          wartosc = Double.Parse(tbWynik.Text);
                      wybor = "";
            */
        }

        private void bC_Click(object sender, EventArgs e)
        {
            tbWynik.Clear();
            wartosc = 0;
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        // pobieramy obiekt i argument e
        {
            switch (e.KeyChar.ToString())
            {
                case "0":
                    b0.PerformClick();
                    break;
                case "1":
                    b1.PerformClick();
                    break;
                case "2":
                    b2.PerformClick();
                    break;
                case "3":
                    b3.PerformClick();
                    break;
                case "4":
                    b4.PerformClick();
                    break;
                case "5":
                    b5.PerformClick();
                    break;
                case "6":
                    b6.PerformClick();
                    break;
                case "7":
                    b7.PerformClick();
                    break;
                case "8":
                    b8.PerformClick();
                    break;
                case "9":
                    b9.PerformClick();
                    break;
                case "+":
                    bDodaj.PerformClick();
                    break;
                case "-":
                    bOdejmij.PerformClick();
                    break;
                case "*":
                    bPomnoz.PerformClick();
                    break;
                case "/":
                    bDzielenie.PerformClick();
                    break;
                case "=":
                    bRownaSie.PerformClick();
                    break;
                default:
                    break;
            }

        }
    }
}
