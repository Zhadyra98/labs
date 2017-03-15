using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public static calculator calculator;
        public Form1()
        {
            InitializeComponent();
            calculator = new calculator();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void number_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (calculator.oper==calculator.Operation.NONE ||
                calculator.oper == calculator.Operation.NUMBER)
            {
                textBox1.Text += btn.Text;
            }
            else if (calculator.oper == calculator.Operation.PLUS)
            {
                calculator.savef(textBox1.Text);
                textBox1.Text = btn.Text;
            }
            calculator.oper = calculator.Operation.NUMBER;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            calculator.oper = calculator.Operation.PLUS;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calculator.saves(textBox1.Text);
            textBox1.Text = calculator.getresplus().ToString();
            calculator.fnumber = calculator.getresplus();
        }

        /* private void button1_Click(object sender, EventArgs e)
         {
             textBox1.Text += '1';
         }

         private void button2_Click(object sender, EventArgs e)
         {
             textBox1.Text += '2';
         }

         private void button3_Click(object sender, EventArgs e)
         {
             textBox1.Text += '3';
         }

         private void button4_Click(object sender, EventArgs e)
         {
             textBox1.Text += '4';
         }

         private void button5_Click(object sender, EventArgs e)
         {
             textBox1.Text += '5';
         }

         private void button6_Click(object sender, EventArgs e)
         {
             textBox1.Text += '6';
         }

         private void button7_Click(object sender, EventArgs e)
         {
             textBox1.Text += '7';
         }

         private void button8_Click(object sender, EventArgs e)
         {
             textBox1.Text += '8';
         }

         private void button9_Click(object sender, EventArgs e)
         {
             textBox1.Text += '9';
         }

         private void button10_Click(object sender, EventArgs e)
         {
             textBox1.Text += '0';
         }
         */

    }
}
