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
            head = null;
            current = head;
            this.KeyPreview = true;
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
            AddToList("+");
            PrintList();
            txtCurrent.Clear();
        }

        private void divide_Click(object sender, EventArgs e)
        {
           
            AddToList("÷");
            PrintList();
            txtCurrent.Clear();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            AddToList("x");
            PrintList();
            txtCurrent.Clear();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            AddToList("-");
            PrintList();
            txtCurrent.Clear();

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
            head = null;
            current = null;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            AddToList("=");
            PrintList();
            txtCurrent.Clear();
            double answer = Calculate();
            txtCurrent.Text = ""+answer;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = txtCurrent.Text + ".";
        }
        private void AddToList(string s)
        {
            if(Double.TryParse(txtCurrent.Text,out first))
            {
                if (head == null)
                {
                    head = new cel();
                    current = head;
                    current.number = first;
                    current.n = true;
                    
                    current.next = new cel();
                    current = current.next;
                    current.symbol = s;
                    current.n = false;
                    current.next = null;
                    
                }
                else
                {
                    current.next = new cel();
                    current = current.next;
                    current.number = first;
                    current.n = true;
                    
                    current.next = new cel();
                    current = current.next;
                    current.symbol = s;
                    current.n = false;
                    current.next = null;

                    
                }

            }
            else
            {
                equation.Text = "ERROR";
                txtCurrent.Clear();
            }
        }
        private void PrintList()
        {
            cel print = head;
            string temp = "";

            while(print!=null)
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
            }
            equation.Text = temp;
        }
       private double Calculate()
        {
          
            Multiply();
            Divide();
            Add();
            Sub();
            return head.number;
        }
        private void Multiply()
        {
            
            cel m = head;
            cel temp;
            while (m.symbol != "=")
            {
                if (m.next.symbol == "x")
                {
                    double answer = m.number * m.next.next.number;
                    temp = m.next.next.next;
                    m.next = temp;
                    m.number = answer;
                }
                else
                {
                    m = m.next;
                }
            }
        }
        private void Divide()
        {

            cel d= head;
            cel temp;
            while (d.symbol != "=")
            {
                if (d.next.symbol == "÷")
                {
                    double answer = d.number / d.next.next.number;
                    temp = d.next.next.next;
                    d.next = temp;
                    d.number = answer;
                }
                else
                {
                    d = d.next;
                }
                
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char p = e.KeyChar;
            if (p == '1' || p == '2' || p == '3' || p == '4' || p == '5' || p == '6' || p == '7' || p == '8' || p == '9' || p == '0')
            {
                if (txtCurrent.Text == "ERROR")
                {
                    txtCurrent.Clear();

                }
                txtCurrent.Text = txtCurrent.Text + p;

            }
            else if (p == 'x' ||p=='+'||p=='÷'||p=='-')
            {
                string s = "" + p;
                AddToList(s);
                PrintList();
                txtCurrent.Clear();
            }
            else if (p == (char)Keys.Enter)
            {
               
                AddToList("");
                PrintList();
                txtCurrent.Clear();               
                double answer = Calculate();
                txtCurrent.Text = ""+answer;
            }
            

            
        }

        private void Add()
        {

            cel a = head;
            cel temp;
            while (a.symbol != "=")
            {
                if (a.next.symbol == "+")
                {
                    double answer = a.number + a.next.next.number;
                    temp = a.next.next.next;
                    a.next = temp;
                    a.number = answer;
                }
                else
                {
                    a = a.next;
                }
                
            }
        }
        private void Sub()
        {

            cel s = head;
            cel temp;
            while (s.symbol != "=")
            {
                if (s.next.symbol == "-")
                {
                    double answer = s.number - s.next.next.number;
                    temp = s.next.next.next;
                    s.next = temp;
                    s.number = answer;
                }
                else
                {
                    s = s.next;
                }
            }
        }
        
    }
}
