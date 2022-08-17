using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldGUI
{
    public partial class SimpleCalculatorUI : Form
    {
        public SimpleCalculatorUI()
        {
            InitializeComponent();
        }

        private void txtAddition_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
                double secondNumber = Convert.ToDouble(txtSecondNumber.Text);
                double result = firstNumber + secondNumber;
                txtResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid values!","Error occur!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtClean_Click(object sender, EventArgs e)
        {
            txtFirstNumber.Text = String.Empty;
            txtSecondNumber.Text = String.Empty;
            txtResult.Text= String.Empty;
        }

        private void txtSecondNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSub_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
                double secondNumber = Convert.ToDouble(txtSecondNumber.Text);
                double result = firstNumber - secondNumber;
                txtResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid values!", "Error occur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
                double secondNumber = Convert.ToDouble(txtSecondNumber.Text);
                double result = firstNumber * secondNumber;
                txtResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid values!", "Error occur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDivision_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
                double secondNumber = Convert.ToDouble(txtSecondNumber.Text);
                double result = firstNumber / secondNumber;
                txtResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid values!", "Error occur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRemainder_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(txtFirstNumber.Text);
                double secondNumber = Convert.ToDouble(txtSecondNumber.Text);
                double result = firstNumber % secondNumber;
                txtResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid values!", "Error occur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    } // end of Class
} // end of namespace
