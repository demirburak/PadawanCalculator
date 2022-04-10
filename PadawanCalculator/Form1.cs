using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PadawanCalculator
{
    public partial class Form1 : Form
    {

        List<islem> islemler = new List<islem>();

        public Form1()
        {
            InitializeComponent();
        }


        private void button9_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
                txtEkran.Text = "";
            txtEkran.Text += "9";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
                txtEkran.Text = "";
            txtEkran.Text += "7";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
                txtEkran.Text = "";
            txtEkran.Text += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
                txtEkran.Text = "";
            txtEkran.Text += "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
                txtEkran.Text = "";
            txtEkran.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
                txtEkran.Text = "";
            txtEkran.Text += "2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
                txtEkran.Text = "";
            txtEkran.Text += "8";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
                txtEkran.Text = "";
            txtEkran.Text += "5";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
                txtEkran.Text = "";
            txtEkran.Text += "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text == "0")
                txtEkran.Text = "";
            txtEkran.Text += "4";
        }

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            if (txtEkran.Text.IndexOf(",") == -1)
            {
                //if (txtEkran.Text == "0")
                //    txtEkran.Text = "";
                txtEkran.Text += ",";
            }
        }

        private void btn_C_Click_1(object sender, EventArgs e)
        {
            txtEkran.Text = "0";
            islemler.Clear();
        }

        private void btnEsittir_Click(object sender, EventArgs e)
        {
            decimal sonuc = 0;
            if (islemler.Count > 0)
            {
                islem a = new islem();
                decimal.TryParse(txtEkran.Text, out decimal sayi);
                a.sayi = sayi;
                a.sembol = islemler[islemler.Count - 1].sembol;
                islemler.Add(a);
                for (int i = 0; i < islemler.Count; i++)
                {
                    if (i > 0)
                    {
                        islem b0 = islemler[i - 1];
                        islem b = islemler[i];
                        if (b0.sembol == "+")
                        {
                            sonuc = sonuc + b.sayi;
                        }
                        if (b0.sembol == "-")
                        {
                            sonuc = sonuc - b.sayi;
                        }
                        if (b0.sembol == "*")
                        {
                            sonuc = sonuc * b.sayi;
                        }
                        if (b0.sembol == "/")
                        {
                            sonuc = sonuc / b.sayi;
                        }
                    }
                    else
                    {
                        islem b = islemler[i];
                        sonuc = b.sayi;
                    }


                }
            }
            txtEkran.Text = sonuc.ToString();
            islemler.Clear();
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            islemekle("-");
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            islemekle("+");
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            islemekle("*");
        }

        private void btnBol_Click(object sender, EventArgs e)
        {

            islemekle("/");
        }

        private void islemekle(string gelenSembol)
        {
            if (txtEkran.Text == "0")
                txtEkran.Text = "";
            islem a = new islem();
            decimal.TryParse(txtEkran.Text, out decimal sayi);
            a.sayi = sayi;
            a.sembol = gelenSembol;
            islemler.Add(a);
            txtEkran.Text = "";
        }

       
        //**** Benim Eklemelerim - Burak D.
        private void button_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEsittir_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad0)
            {
                button0_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad1)
            {
                button1_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                button2_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                button3_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                button4_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                button5_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                button6_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                button7_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                button8_Click(null, null);
            }
            else if (e.KeyCode == Keys.NumPad9)
            {
                button9_Click(null, null);
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                btnVirgul_Click(null, null);
            }
            else if (e.KeyCode == Keys.C || e.KeyCode == Keys.Escape)
            {
                btn_C_Click_1(null, null);
            }
            else if (e.KeyCode == Keys.Add)
            {
                btnTopla_Click(null, null);
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                btnCikart_Click(null, null);
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                btnCarp_Click(null, null);
            }
            else if (e.KeyCode == Keys.Divide)
            {
                btnBol_Click(null, null);
            }
        }
       
    }
}

