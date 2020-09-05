using System;
using System.Windows.Forms;

namespace TO_DO_LIST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textboxtext1 = textBox1.Text;
            listView1.Items.Add(textboxtext1);
            checkBox1.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textboxtext2 = textBox2.Text; 
            
            listView1.Items.Add(textboxtext2);
            checkBox2.Checked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string textboxtext4 = textBox4.Text; 
            listView1.Items.Add(textboxtext4);
            checkBox4.Checked = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string textboxtext3 = textBox3.Text;

            listView1.Items.Add(textboxtext3);
            checkBox3.Checked = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string textboxtext6 = textBox6.Text; 

            listView1.Items.Add(textboxtext6);
            checkBox6.Checked = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string textboxtext5 = textBox5.Text;

            listView1.Items.Add(textboxtext5);
            checkBox5.Checked = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string textboxtext12 = textBox12.Text;

            listView1.Items.Add(textboxtext12);
            checkBox12.Checked = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string textboxtext11 = textBox11.Text;

            listView1.Items.Add(textboxtext11);
            checkBox11.Checked = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string textboxtext10 = textBox10.Text;

            listView1.Items.Add(textboxtext10);
            checkBox10.Checked = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string textboxtext9 = textBox9.Text;
            listView1.Items.Add(textboxtext9);
            checkBox9.Checked = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string textboxtext8 = textBox8.Text; 
            listView1.Items.Add(textboxtext8);
            checkBox8.Checked = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string textboxtext7 = textBox7.Text;
            listView1.Items.Add(textboxtext7);
            checkBox7.Checked = true;

        }
      
        private void button15_Click(object sender, EventArgs e)
        {
            string textboxtext15 = textBox15.Text;
            listView1.Items.Add(textboxtext15);
            checkBox15.Checked = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string textboxtext14 = textBox14.Text; 
            listView1.Items.Add(textboxtext14);
            checkBox14.Checked = true;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string textboxtext13 = textBox13.Text;
            listView1.Items.Add(textboxtext13);
            checkBox13.Checked = true;
        }
    }
}
