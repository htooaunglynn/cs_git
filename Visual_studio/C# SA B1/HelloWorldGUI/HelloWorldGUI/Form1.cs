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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSayHi_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, Today is super Sunday.", "My App", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginUI loginUI = new LoginUI();
            loginUI.Show();
        }

        private void btnGoToSimpleCalculatorUI_Click(object sender, EventArgs e)
        {
            SimpleCalculatorUI simpleCalculatorUI = new SimpleCalculatorUI();
            simpleCalculatorUI.Show();
        }
    }
}
