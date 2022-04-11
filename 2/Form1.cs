using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {

        double first_num, sec_num;
        string operat;


        public Form1()
        {
            InitializeComponent();
        }


        #region Clearing Methods

        private void off_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void on_btn_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "0";
        }

        #endregion


        #region Number Methods

        private void period_Click(object sender, EventArgs e)
        {
            if (period.Text == ".")
            {
                if (txtOutput.Text.Contains("."))
                {
                    txtOutput.Text = txtOutput.Text + period.Text;
                }

            }
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Text = "0";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "0";
            }

        }

            private void one_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Text = "1";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "1";
            }
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Text = "2";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "2";
            }
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Text = "3";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "3";
            }
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Text = "4";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "4";
            }
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Text = "5";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "5";
            }
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Text = "6";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "6";
            }
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Text = "7";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "7";
            }
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Text = "8";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "8";
            }
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text == "0")
            {
                txtOutput.Text = "9";
            }
            else
            {
                txtOutput.Text = txtOutput.Text + "79";
            }
        }
        #endregion

        #region Operator Methods
        private void divide_Click(object sender, EventArgs e)
        {
            first_num = double.Parse(txtOutput.Text);
            operat = "/";
            txtOutput.Text = "";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            first_num = double.Parse(txtOutput.Text);
            operat = "*";
            txtOutput.Text = "";
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            first_num = double.Parse(txtOutput.Text);
            operat = "-";
            txtOutput.Text = "";
        }

        private void add_Click(object sender, EventArgs e)
        {
            first_num = double.Parse(txtOutput.Text);
            operat = "+";
            txtOutput.Text = "";
        }
        private void add_or_sub_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtOutput.Text);
            txtOutput.Text = Convert.ToString(-1 * a);
        }

        private void equals_Click(object sender, EventArgs e)
        {
            sec_num = double.Parse(txtOutput.Text);

            switch (operat)
            {
                case "+":
                    txtOutput.Text = (first_num + sec_num).ToString();
                    break;
                case "-":
                    txtOutput.Text = (first_num + sec_num).ToString();
                    break;
                case "/":
                    txtOutput.Text = (first_num + sec_num).ToString();
                    break;
                case "*":
                    txtOutput.Text = (first_num + sec_num).ToString();
                    break;
                default:
                    break;
            }

        }

        #endregion
    }
}
