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
       public double[] numbers = new double[100];
       public char[] sim1 = new char[15];
       public char[] sim2 = new char[15];
       public int i = 0,j = 0,k = 0;
       public string num= "";
       public double result;
       public bool output = false;
        public Form1()
        {
            InitializeComponent();

        }

       

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            num = "";
            for (int g = 0; g < i; g++)
            {
                numbers[g] = -1;
                sim1[g] = ' ';
                sim2[g] = ' ';
            }

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
            for(int l = 0; l <= i; l++)
            {
                if(sim1[l] == '*' || sim1[l] == '/')
                {
                    result = numbers[l];
                    k = l;
                    break;
                }
            }
          
            foreach(char doing in sim1)
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
                }

            }
            if (output)
            {
                k = 0;
            }
            else
            {
                k = -1;
            }
            foreach (char doing2 in sim2)
            {
                
                switch (doing2)
                {
                    case '+':
                        result += numbers[k+1];
                        k++;
                        break;
                    case '-':
                        result -= numbers[k];
                        k++;
                        break;
                   
                }
            }

            textBox1.Text = result.ToString();
            for (int g = 0; g < i; g++)
            {
                numbers[g] = -1;
                sim1[g] = ' ';
                sim2[g] = ' ';
            }
            num = result.ToString();
            i = 0;
            j = 0;
            k = 0;
            output = true;

        }

       

        private void buttonPr_Click(object sender, EventArgs e)
        {
            numbers[i] = double.Parse(num);
            sim2[j] = ' ';
            sim1[j] = '*';
            num = "";
            textBox1.Text += " * ";   
            i++;
            j++;
        }

        

        private void buttonDel_Click(object sender, EventArgs e)
        {
            numbers[i] = double.Parse(num);
            sim1[j] = '/';
            sim2[j] = ' ';
            num = "";
            textBox1.Text += " / ";
            i++;
            j++;
        } 
        
        private void buttonPl_Click(object sender, EventArgs e)
        {
            numbers[i] = double.Parse(num);
            sim2[j] = '+';
            sim1[j] = ' ';
            num = "";
            textBox1.Text += " + ";
            i++;
            j++;
        }
        private void buttonMin_Click(object sender, EventArgs e)
        {
            numbers[i] = double.Parse(num);
            sim2[j] = '-';
            sim1[j] = ' ';
            num = "";
            textBox1.Text += " - ";
            i++;
            j++;
        }
    }
}
