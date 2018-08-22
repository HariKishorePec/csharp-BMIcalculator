using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMIcalculator
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double ht, wt, BMI=0;
            
            if (txtWeight.Text != "" && txtHeight.Text != "")
            {
                wt = double.Parse(txtWeight.Text);
                ht = double.Parse(txtHeight.Text);

                BMI = Math.Round(wt / (ht * ht));
                lblBmi.Text += BMI;

                if (BMI > 25.0)
                {
                    lblComment.Text += " Overweight BMI.";
                }
                else if (BMI < 18.5)
                {
                    lblComment.Text += "Underweight BMI.";
                }
                else
                {
                    lblComment.Text += "Normal BMI.";
                }

            }
            else
            {
                MessageBox.Show("Height and/or Weight cant not be empty!", "Error Message", MessageBoxButtons.OK);
                ClrResult();
            }


            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtWeight.Text = "";
            txtHeight.Text = "";
            lblBmi.Text = "BMI :";
            lblComment.Text = "Comment :";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void ClrResult()
        {
            lblBmi.Text = "BMI :";
            lblComment.Text = "Comment :";
        }
    }
}
