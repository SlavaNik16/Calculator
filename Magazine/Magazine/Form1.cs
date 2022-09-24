using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazine
{
    public partial class Form1 : Form
    {
        public decimal result = 1;
        public string output = "Продукт|Кол-во|Цена|Итог";
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem = "0";
            count.Value = 0;
            textBox1.Text = output;
            output = "";
        }

    

    private void button1_Click(object sender, EventArgs e)
        {
            output += $"\n{this.NameBox.Text}| \r";
            output += $"{this.count.Text}| \r";
            output += $"{this.PriceBox.Text}| \r";
            output += $"{this.resultBox.Text} \r\n";
            textBox1.Text = output;
            output += "\n";
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {       
            
            TestCheck();
            
        }
        private void TestCheck()
        {
            this.button1.Enabled = decimal.TryParse(PriceBox.Text, out decimal price) &&
                int.TryParse(count.Text, out int counts) &&
                !string.IsNullOrWhiteSpace(NameBox.Text);
        }

        

       

        private void PriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;

            }
            TestCheck();
        }

        private void count_ValueChanged(object sender, EventArgs e)
        {
            vivod();
        }

        private void PriceBox_TextChanged(object sender, EventArgs e)
        {
            vivod();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            vivod();
        }
        private void vivod()
        {
            if (PriceBox.Text.Length != 0 && count.Value != 0)
            {
                decimal pr = decimal.Parse(PriceBox.Text);
                decimal sk = decimal.Parse(comboBox1.Text);
                result = (pr - (pr * sk / 100)) * count.Value;
            }
            else
            {
                result = 0;
            }
            resultBox.Text = result.ToString();
            TestCheck();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            output = "";
            textBox1.Text = "";
        }
    }
}
