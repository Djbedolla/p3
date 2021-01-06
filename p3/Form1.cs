using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p3
{
    public partial class Form1 : Form
    {
        double first, second, answer;
        string function;
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 9;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            equation.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 8;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(Double.TryParse(txtCurrent.Text, out first))
            {
                function = "+";
                equation.Text = txtCurrent.Text + function;
            }
            else
            {
                txtCurrent.Text = "ERROR";
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtCurrent.Text, out first))
            {
                function = "÷";
                equation.Text = txtCurrent.Text + function;
            }
            else
            {
                txtCurrent.Text = "ERROR";
            }
        }

        private void mul_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtCurrent.Text, out first))
            {
                function = "x";
                equation.Text = txtCurrent.Text + function;
            }
            else
            {
                txtCurrent.Text = "ERROR";
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtCurrent.Text, out first))
            {
                function = "-";
                equation.Text = txtCurrent.Text + function;
            }
            else
            {
                txtCurrent.Text = "ERROR";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + ".";
        }
    }
}
