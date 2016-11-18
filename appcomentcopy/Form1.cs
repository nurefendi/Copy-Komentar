using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace appcomentcopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ( radioButton1.Checked == true)
            {
                string text;
                using (var streamReader = new StreamReader(@"ytccna.txt", Encoding.UTF8))
                {
                    text = streamReader.ReadToEnd();
                    textBox1.Text = text;
                    textBox1.SelectAll();
                }
            } else { textBox1.Text = ""; }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                string text;
                using (var streamReader = new StreamReader(@"ytccnaeng.txt", Encoding.UTF8))
                {
                    text = streamReader.ReadToEnd();
                    textBox1.Text = text;
                    textBox1.SelectAll();
                }
            }
            else { textBox1.Text = ""; }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                string text;
                using (var streamReader = new StreamReader(@"ytbejo.txt", Encoding.UTF8))
                {
                    text = streamReader.ReadToEnd();
                    textBox1.Text = text;
                    textBox1.SelectAll();
                }
            }
            else { textBox1.Text = ""; }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                string text;
                using (var streamReader = new StreamReader(@"ytbejoeng.txt", Encoding.UTF8))
                {
                    text = streamReader.ReadToEnd();
                    textBox1.Text = text;
                    textBox1.SelectAll();
                }
            }
            else { textBox1.Text = ""; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text=="")
            {
                MessageBox.Show("Text is not null!");
            }
            else { textBox1.Copy(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button is not active!");
        }
    }
}
