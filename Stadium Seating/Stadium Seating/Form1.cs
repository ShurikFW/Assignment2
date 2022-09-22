using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Seating
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int class_A_price = 15;
                int class_A_amount = int.Parse(textBox1.Text);
                int total_A = total_price(class_A_amount, class_A_price);
                label8.Text = "$" + total_A;
                int class_B_price = 12;
                int class_B_amount = int.Parse(textBox2.Text);
                int total_B = total_price(class_B_amount, class_B_price);
                label9.Text = "$" + total_B;
                int class_C_price = 9;
                int class_C_amount = int.Parse(textBox3.Text);
                int total_C = total_price(class_C_amount, class_C_price);
                label12.Text ="$" + total_C;
                int total = total_A + total_B + total_C;
                label13.Text = "$" + total.ToString();
            }
            catch
            {
                MessageBox.Show("Input string was not a correct format");
            }

        }
        private int total_price(int amount, int ticket_class_price)
        {
            return   amount * ticket_class_price;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            textBox3.Text = " ";
            label8.Text = " ";
            label9.Text = " ";
            label12.Text = " ";
            label13.Text = " ";
        }
    }
}
