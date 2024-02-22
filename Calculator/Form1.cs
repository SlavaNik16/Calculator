﻿using System;
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
       public bool perv = true; 
        public Form1()
        {
            InitializeComponent();

        }

       

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            num = "";
            for (int g = 0; g <=i; g++)
            {
                numbers[g] = -1;
                sim1[g] = ' ';
                sim2[g] = ' ';
            }
            i = 0;
            j = 0;
            k = 0;

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
            
            for(int l = 0; l <= i; l++)
            {
                if(sim1[l] == '*' || sim1[l] == '/')
                {
                    k = l;
                    break;
                }
            }
          
            foreach(char doing in sim1)
            {
                
                switch (doing)
                {
                    case '*':
                        k++;
                        numbers[k] *= numbers[k - 1];
                        for (int p = k-1; p <= i; p++) //Двигаемся слева направо с заданной позиции
                        {
                            numbers[p] = numbers[p + 1]; //Сдвигаем элементы
                        }
                        numbers[i] = 0; //Обнуляем последний элемент (часто в целях безопасности)

                        perv = false;
                        k--;
                        break;
                    case '/':
                        k++;
                        numbers[k-1] /= numbers[k];
                        for (int p = k; p <= i; p++) //Двигаемся слева направо с заданной позиции
                        {
                            numbers[p] = numbers[p + 1]; //Сдвигаем элементы
                        }
                        numbers[i] = 0; //Обнуляем последний элемент (часто в целях безопасности)

                        perv = false;
                        k--;
                        break;
                    case ' ':
                        if (!perv)
                        {
                            k++;
                        }                       
                        break;
                }

            }
            k = 0;
            foreach (var doing in sim2) 
            {
                switch (doing)
                {
                    case '+': 
                        numbers[0] += numbers[k+1];
                        k++;
                        break;
                    case '-':
                        numbers[0] -= numbers[k + 1];
                        k++;
                        break;
                }
            }
            textBox1.Text = numbers[0].ToString();
            num = numbers[0].ToString();
            for (int g = 0; g <= i; g++)
            {
                numbers[g] = -1;
                sim1[g] = ' ';
                sim2[g] = ' ';
            }
           
            i = 0;
            j = 0;
            k = 0;
            perv=true;

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
