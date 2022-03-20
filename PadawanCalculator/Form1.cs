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
            txtEkran.Text += "";
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
            if (txtEkran.Text == "0")
                txtEkran.Text = "";
            txtEkran.Text += ",";
        }


        private void btn_C_Click(object sender, EventArgs e)
        {
            txtEkran.Text = "0" ;
        }


    }
}

