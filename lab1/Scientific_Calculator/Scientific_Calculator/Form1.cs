using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scientific_Calculator
{
    public partial class Scientific_Calculator : Form
    {
        string input = string.Empty;
        string Op1 = string.Empty;
        string Op2 = string.Empty;
        char Operator;
        double res = 0.0;
        String s, x;


        public Scientific_Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty; 
            input = input + "1"; 
            this.textBox1.Text += input;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
        }

        private void button11_Click(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "6";
            this.textBox1.Text += input;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty; 
            input += "2";
            this.textBox1.Text += input;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "3";
            this.textBox1.Text += input;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "4";
            this.textBox1.Text += input;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "5";
            this.textBox1.Text += input;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "7";
            this.textBox1.Text += input;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "8";
            this.textBox1.Text += input;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "9";
            this.textBox1.Text += input;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            input += "0";
            this.textBox1.Text += input;
        }

        private void add_Click(object sender, EventArgs e)
        {
            Op1 = input; 
            Operator = '+';
            input = string.Empty;
        }

        private void sub_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '-';
            input = string.Empty;
        }

        private void mul_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '*';
            input = string.Empty;
        }

        private void div_Click(object sender, EventArgs e)
        {
            Op1 = input;
            Operator = '/';
            input = string.Empty;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            Op2 = input;
            double num1, num2; double.TryParse(Op1, out num1); 
            double.TryParse(Op2, out num2); 
            if (Operator == '+')
                {
                    res = num1 + num2; 
                    this.textBox1.Text = res.ToString();
                }
           else if (Operator == '-')
                {
                    res = num1 - num2; 
                    textBox1.Text = res.ToString();
                }
            else if (Operator == '*')
                {
                    res = num1 * num2; 
                    textBox1.Text = res.ToString();
                }
            else if (Operator == '/')
                {
                    if (num2 != 0)
                        {
                            res = num1 / num2; textBox1.Text = res.ToString();
                        }
                    else
                        {
                            textBox1.Text = "DIV/Zero!";
                        }
                }
           input = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
