using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculette
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string buffer = dt.Compute(textbox_History.Text + textbox_current.Text, "").ToString();
            textbox_History.Text += textbox_current.Text;
            textbox_current.Text = buffer; 
            
        }
       private void happenToCalc(char tohappend)
        {
            textbox_current.Text = textbox_current.Text + tohappend; 
        }

        private void button_calc_1_Click(object sender, EventArgs e)
        {
            happenToCalc('1');
        }

        private void button_calc_2_Click(object sender, EventArgs e)
        {
            happenToCalc('2');
        }

        private void button_calc_3_Click(object sender, EventArgs e)
        {
            happenToCalc('3');
        }

        private void button_calc_4_Click(object sender, EventArgs e)
        {
            happenToCalc('4');
        }

        private void button_calc_5_Click(object sender, EventArgs e)
        {
            happenToCalc('5');
        }

        private void button_calc_6_Click(object sender, EventArgs e)
        {
            happenToCalc('6');
        }

        private void button_calc_7_Click(object sender, EventArgs e)
        {
            happenToCalc('7');
        }

        private void button_calc_8_Click(object sender, EventArgs e)
        {
            happenToCalc('8');
        }

        private void button_calc_9_Click(object sender, EventArgs e)
        {
            happenToCalc('9');
        }

        private void button_calc_comma_Click(object sender, EventArgs e)
        {
            happenToCalc(',');
        }

        private void button_calc_add_Click(object sender, EventArgs e)
        {
            textbox_current.Text += "+";
            textbox_History.Text += textbox_current.Text;
            textbox_current.Text = "";
        }

        private void button_calc_0_Click(object sender, EventArgs e)
        {
            happenToCalc('0');
        }

        private void button_calc_sub_Click(object sender, EventArgs e)
        {
            textbox_current.Text += "-";
            textbox_History.Text += textbox_current.Text;
            textbox_current.Text = "";
        }
    }
}
