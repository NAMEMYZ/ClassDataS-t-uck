using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Collection;

namespace CW1
{
    public partial class Form1 : Form
    {
        Collection.Collection x = new LinkedHeaderCollection();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x.Add(textBox1.Text);
            MessageBox.Show("Added");
            label22();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(x.Contains(textBox2.Text))
            {
                MessageBox.Show("Found");
            }
            else
            {
                MessageBox.Show("Not found");
            }
            
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (x.Contains(textBox3.Text))
            {
                MessageBox.Show("Delete Complete");
                x.remove(textBox3.Text);
                
            }
            else
            {
                MessageBox.Show("Not found");
            }
            label22();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "จำนวน " + x.size() + " คน";
        }
        private void label22()
        {
            label2.Text = "จำนวน " + x.size() + " คน";
        }
    }
}
