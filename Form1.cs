using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        double sayi1, sayi2, sonuc;
        int sayac,a=0;



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //textBox1.Text += "0";
            textBox1.Clear();
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
           

        }

        private void button18_Click(object sender, EventArgs e)
        {// ........
            textBox1.Text += ".";

        }


        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string yazi = textBox1.Text;
            textBox1.Text = Convert.ToString(yazi.Substring(0, (yazi.Length - 1)));

        }
        private void button12_Click(object sender, EventArgs e)
        {// +++++++

            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            sayac = 1;

        }

        private void button13_Click(object sender, EventArgs e)
        { //------
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            sayac = 2;

        }

        private void button14_Click(object sender, EventArgs e)
        {// ***
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            sayac = 3;

        }

        private void button15_Click(object sender, EventArgs e)
        { // ////
            sayi1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
            sayac = 4;

        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                sayi2 = Convert.ToDouble(textBox1.Text);

                if (sayac == 1)
                {
                    sonuc = sayi1 + sayi2;

                    textBox1.Text = Convert.ToString(sonuc);
                }
                if (sayac == 2)
                {
                    sonuc = sayi1 - sayi2;

                    textBox1.Text = Convert.ToString(sonuc);
                }
                if (sayac == 3)
                {
                    sonuc = sayi1 * sayi2;

                    textBox1.Text = Convert.ToString(sonuc);
                }
                if (sayac == 4)
                {
                    sonuc = sayi1 / sayi2;

                    textBox1.Text = Convert.ToString(sonuc);

                }
            }
            a += 1;
            
        }

        private void button(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
            textBox1.Clear();
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsLetter(e.KeyChar);
        }
       
    }
}
            
                           
                 
        
    

