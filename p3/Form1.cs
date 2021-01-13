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
        cel head;
        cel current;
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
            head = new cel();
            current = head;
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

                AddToList(first,"+");
                
                txtCurrent.Clear();
                PrintList();
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
                AddToList(first, "÷");
                txtCurrent.Clear();
                PrintList();
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
                AddToList(first, "-");
                txtCurrent.Clear();
                PrintList();
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
                AddToList(first, "-");
                txtCurrent.Clear();
                PrintList();
            }
            else
            {
                txtCurrent.Text = "ERROR";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCurrent.Clear();
        }

        private void CLall_Click(object sender, EventArgs e)
        {
            txtCurrent.Clear();
            first = second = answer = 0;
            equation.Text = "";
            function = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtCurrent.Text, out second))
            {
                if (function == "+")
                {
                    answer = first + second;
                }
                else if(function == "-")
                {
                    answer = first - second;
                }
                else if (function == "x")
                {
                    answer = first * second;
                }
                else if (function == "÷")
                {
                    answer = first / second;
                }
                txtCurrent.Text = "" + answer;
                equation.Text = equation.Text + second + "=";
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
        private void AddToList(double x, string s)
        {
            current.number = x;
            current.n = true;
            current.s = false;
            current = current.next;
            current = new cel();
            current.symbol = s;
            current.s = true;
            current.n = false;
            current = current.next;
            current = new cel();
        }
        private void PrintList()
        {
            cel print = head;
            string temp = "";

            do
            {
                if (print.n)
                {
                    temp = temp + print.number;

                }
                else
                {
                    temp = temp + print.symbol;
                }
                print = print.next;
            } while (print != current);
        }
    }
}
