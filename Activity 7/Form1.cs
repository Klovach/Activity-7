using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /* Declare and initialize variables. Our input from the terms textbox is assigned to the variable terms.
             * Our double denominator will be utilized as the denominator of the given formula. Our double, sum,
             will calculate the sum of the series of integers. */
            int terms = Convert.ToInt32(txtTerms.Text);
            double denominator = 1;
            double sum = 0;

            /* For as long as the number of terms is greater than i, increment the counter by one. 
            A for loop is ideal in instances where we would like to repeat a block of code a known number of times.
            In this case, we want our block of code to repeat until we have no more terms to perform this formula on.*/
            for (int i = 0; i < terms; i++)
            {
                if (i % 2 == 0) 
                {
                    sum = sum + 4 / denominator;
                }
                else
                {
                    sum = sum - 4 / denominator;
                }
                denominator = denominator + 2;
            }

            /* This line of code will change the text assigned to the answer label to the text below. The escape characters,
            /n/n will ensure that the answer is spaced correctly. */
            lblAnswer.Text = "Approximate value of PI after " + terms + " Terms" + "\n\n" + "=" + sum.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exit application. 
            Application.Exit(); 
        }
    }
}
