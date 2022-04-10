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
            if (txtEkran.Text.IndexOf(",")==-1)
            {
                if (txtEkran.Text == "0")
                    txtEkran.Text = "";
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
            islem a = new islem();
            decimal.TryParse(txtEkran.Text, out decimal sayi);
            a.sayi = sayi;
            a.sembol = islemler[islemler.Count - 1].sembol;
            islemler.Add(a);
            for (int i = 0; i < islemler.Count; i++)
            {
                if (i>0)
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
    }
}

