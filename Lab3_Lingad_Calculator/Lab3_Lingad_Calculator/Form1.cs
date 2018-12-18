using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3_Lingad_Calculator
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

        private void btn1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            DeclareVar.tot1 = 0;
            DeclareVar.tot2 = 0;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            DeclareVar.divbtnclk = true;
            DeclareVar.mulbtnclk = false;
            DeclareVar.plsbtnclk = false;
            DeclareVar.minbtnclk = false;
            DeclareVar.tot1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            DeclareVar.divbtnclk = false;
            DeclareVar.mulbtnclk = true;
            DeclareVar.plsbtnclk = false;
            DeclareVar.minbtnclk = false;
            DeclareVar.tot1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DeclareVar.divbtnclk = false;
            DeclareVar.mulbtnclk = false;
            DeclareVar.plsbtnclk = true;
            DeclareVar.minbtnclk = false;
            DeclareVar.tot1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            DeclareVar.divbtnclk = false;
            DeclareVar.mulbtnclk = false;
            DeclareVar.plsbtnclk = false;
            DeclareVar.minbtnclk = true;
            DeclareVar.tot1 = Convert.ToDouble(textBox1.Text);
            textBox1.Clear();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            DeclareVar.tot2 = Convert.ToDouble(textBox1.Text);

            if (DeclareVar.divbtnclk == true)
            {
                textBox1.Text = (DeclareVar.tot1 / DeclareVar.tot2).ToString();
            }

            else if (DeclareVar.mulbtnclk == true)
            {
                textBox1.Text = (DeclareVar.tot1 * DeclareVar.tot2).ToString();
            }

            else if (DeclareVar.plsbtnclk == true)
            {
                textBox1.Text = (DeclareVar.tot1 + DeclareVar.tot2).ToString();
            }

            else
            {
                textBox1.Text = (DeclareVar.tot1 - DeclareVar.tot2).ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        
        
      

       
      
    }
}
