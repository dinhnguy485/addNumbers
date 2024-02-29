using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace addNumbers
{
    public partial class Form1 : Form
    {
        int num;
        double sum;
        int number;
        
        public Form1()
        {
            number = 0;
            sum = 0;
            InitializeComponent();
            resetButton.Enabled = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                num = Convert.ToInt32(numInput.Text);
                if (num != 0)
                {
                    number++;
                    sum = sum + num;
                    outputLabel.Text = $"{num} was added to the sum";
                }
                else
                {
                    resetButton.Enabled = true;
                    sum = (sum + 0) / number;
                    outputLabel.Text = $"{sum} is the average ";
                }
            }
            catch (FormatException)
            {
                resetButton.Enabled = true;

                MessageBox.Show("please enter a valid number");
            }


            
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            num = 0;
            sum = 0;
            number = 0;
            outputLabel.Text = " ";
            numInput.Text = " ";
            resetButton.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
