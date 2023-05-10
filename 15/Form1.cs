using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R, H, S, V;
            R = Double.Parse(textBox1.Text);
            H = Double.Parse(textBox2.Text);
            Cilindr C = new Cilindr(H, R);
            S = C.Square();
            V = C.VVV();
            label1.Text = "Площа поверхні \n= " + S.ToString();
            label2.Text = "Об'єм  \n= " + V.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
  

        private void button3_Click(object sender, EventArgs e)
        {
 Form2 fz = new Form2();
            fz.Show();
        }
    }
    }

