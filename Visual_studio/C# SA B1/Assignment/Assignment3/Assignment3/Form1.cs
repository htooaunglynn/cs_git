using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double incomeNumber = Convert.ToDouble(txtIncome.Text);
                double taxNumber = Convert.ToDouble(txtShowBox.Text);
                double result = (taxNumber / 100) * incomeNumber;
                txtOutputDisplay.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid values!", "Error occur!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtIncome_TextChanged(object sender, EventArgs e)
        {
           // txtIncome.Text = String.Empty;
        }

        private void txtShowBox_TextChanged(object sender, EventArgs e)
        {
           // txtShowBox.Text = String.Empty;
        }

        
    }
}
