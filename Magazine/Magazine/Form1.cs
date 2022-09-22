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
        public double result = 1;
        public Form1()
        {
            InitializeComponent();
            NameBox.Tag = false;
            CountBox.Tag = false;
            PriceBox.Tag = false;
            resultBox.Tag = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string output;
            output = $"{this.NameBox.Text} \r";
            output += $"{this.CountBox.Text} \r";
            output += $"{this.PriceBox.Text} \r";
            output += $"{this.resultBox.Text} \r\n";
            textBox1.Text = output;
        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            this.NameBox.Tag = NameBox.Text.Length != 0;
            
            TestCheck();
        }
        private void TestCheck()
        {
            this.button1.Enabled = (((bool)(NameBox.Tag)) &&
                           ((bool)(CountBox.Tag)) &&
                           ((bool)(PriceBox.Tag)) &&
                           ((bool)(resultBox.Tag)));
        }

        private void CountBox_TextChanged(object sender, EventArgs e)
        {
            this.CountBox.Tag = CountBox.Text.Length != 0;
            result *= double.Parse(CountBox.Text);
            TestCheck();
        }

       

        private void PriceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PriceBox.Tag = false;
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
            else
            {
                PriceBox.Tag = true;
                result *= double.Parse(PriceBox.Text);
            }
            TestCheck();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           result -= (PriceBox.Text -  double.Parse(comboBox1.SelectedIndex.ToString()));
        }
    }
}
