using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
       public int[] numbers = new int[100];
       public char[] sim = new char[100];
       public int i = 0,j = 0,k = 0;
       public string num= "";
       public int result;
        public Form1()
        {
            InitializeComponent();

        }

       

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            num += "1";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            num += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            num += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            num += "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            num += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            num += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            num += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            num += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            num += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            num += "0";
        }

        private void buttonRes_Click(object sender, EventArgs e)
        {
            numbers[i] = int.Parse(num);
            result = numbers[0];
          
            foreach(char doing in sim)
            {
                switch (doing)
                {
                    case '*':
                        result *= numbers[k+1];
                        k++;
                        break;
                    case '/':
                        result /= numbers[k + 1];
                        k++;
                        break;
                    case '+':
                        result += numbers[k + 1];
                        k++;
                        break;
                    case '-':
                        result -= numbers[k + 1];
                        k++;
                        break;
                }
            }
            textBox1.Text = result.ToString();
            for (int g = 0; g < i; g++)
            {
                numbers[g] = -1;
                sim[g] = ' ';
            }
            num = result.ToString();
            i = 0;
            j = 0;
            k = 0;

        }

        private void buttonPr_Click(object sender, EventArgs e)
        {
            numbers[i] = int.Parse(num);
            sim[j] = '*';
            num = "";
            textBox1.Text += " * ";   
            i++;
            j++;
        }
    }
}
