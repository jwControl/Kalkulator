using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a, b = 0;
        char rodzajDzialania = ' ';
        int ileMiejscPoPrzecinku = 0;

        private void bWynik_Click(object sender, EventArgs e)
        {
            switch (rodzajDzialania)
            {
                case ('+'):
                    tbWynik.Text = (a + b).ToString();
                    break;
                case ('-'):
                    tbWynik.Text = (a - b).ToString();
                    break;
                case ('*'):
                    tbWynik.Text = (a * b).ToString();
                    break;
                case ('/'):
                    if (b == 0)
                    {
                        tbWynik.Text = ("Nie dziel przez 0!");
                    }
                    else
                    tbWynik.Text = (a / b).ToString();
                    break;
            }
            a = 0;
            b = 0;
        }
    
        private void bOdejmowanie_Click(object sender, EventArgs e)
        {
            rodzajDzialania = '-';
            tbWynik.Text = "";
        }
        private void bDodawanie_Click(object sender, EventArgs e)
        {
            rodzajDzialania = '+';
            tbWynik.Text = "";
        }
        private void bMnozenie_Click(object sender, EventArgs e)
        {
            rodzajDzialania = '*';
            tbWynik.Text = "";
        }
        private void bDzielenie_Click(object sender, EventArgs e)
        {
            rodzajDzialania = '/';
            tbWynik.Text = "";
        }
        private void b0_Click(object sender, EventArgs e)
        {
            Dzialanie(0);
        }
        private void b3_Click(object sender, EventArgs e)
        {
            Dzialanie(3);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Dzialanie(2);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Dzialanie(6);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Dzialanie(5);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Dzialanie(4);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Dzialanie(9);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Dzialanie(8);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Dzialanie(7);
        }
        private void bKropka_Click(object sender, EventArgs e)
        {
            if (tbWynik.Text == "")
            {
                tbWynik.Text = "0";
                tbWynik.Text += ".";
                ileMiejscPoPrzecinku = 1;
            }
            else
            {
                tbWynik.Text += ".";
                ileMiejscPoPrzecinku = 1;
            }
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            char[] array = tbWynik.Text.ToCharArray();
            string t = tbWynik.Text;
            tbWynik.Text = t.Remove(array.Length - 1);

            if (!(tbWynik.Text == "") && b == 0)
            {

                string aString = a.ToString();
                char[] array2 = aString.ToCharArray();
                aString = aString.Remove(array2.Length - 1);
                if (aString.Length > 0)
                {
                    if (aString[aString.Length - 1] == '.')
                    {
                        a = double.Parse(aString);
                        tbWynik.Text = a.ToString();
                    }
                    else
                        a = double.Parse(aString);
                }
                else if (aString.Length == 0)
                {
                    a = 0;
                    tbWynik.Text = "";
                }
            }
            else
            {
                string bString = b.ToString();
                char[] array3 = bString.ToCharArray();
                bString = bString.Remove(array3.Length - 1);
                if (bString.Length > 0)
                {
                    if (bString[bString.Length - 1] == '.')
                    {
                        b = double.Parse(bString);
                        tbWynik.Text = b.ToString();
                    }
                    else
                        b = double.Parse(bString);
                }
                else if (bString.Length == 0)
                {
                    b = 0;
                    tbWynik.Text = "";
                }
            }
        }



        private void bCE_Click(object sender, EventArgs e)
        {
            a = b = 0;
            // kropka = false;
            ileMiejscPoPrzecinku = 0;
            tbWynik.Text = "";
            rodzajDzialania = ' ';
        }
        private void Dzialanie(int liczba)
        {
            if (rodzajDzialania == ' ') //radzaj dzialania jest puste wiec wiemy ze nie wcisnelismy jeszcze zadnego przycisku dzialania
            {
                if (!tbWynik.Text.Contains(".")) // dzialania funckji dla liczb calkowitych
                    a = a * 10 + liczba;
                else //dzialanie funkcji dla liczb zmiennoprzecinkowych
                {
                    if (liczba != 0)
                    {
                        a = a + liczba / (Math.Pow(10, ileMiejscPoPrzecinku));
                        ileMiejscPoPrzecinku++;
                    }
                    else ++ileMiejscPoPrzecinku; //po co
                }
            }
            else
            {
                if (!tbWynik.Text.Contains(".")) // dzialania funckji dla liczb calkowitych if(true) to wchodzi w warunek)
                    b = b * 10 + liczba;
                else //dzialanie funkcji dla liczb zmiennoprzecinkowych if(false) to wchodzi w ten warunek
                {
                    if (liczba != 0)
                    {
                        b = b + liczba / (Math.Pow(10, ileMiejscPoPrzecinku));
                        ileMiejscPoPrzecinku++;
                    }
                    else ++ileMiejscPoPrzecinku; //dodaje 1 a pozniej przypisuje do zmiennej ile miejsc po przecinku
                }
            }

            tbWynik.Text += liczba.ToString();

        }


    }
}

