using System;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form                                                                               
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address=txtAddress.Text;

            string password = txtPassword.Text;
            string comPassword=txtComfirmPassword.Text;

            if(password!=comPassword)
            {
                MessageBox.Show("Password is not equal","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

           else if(String.IsNullOrEmpty(name) || String.IsNullOrEmpty(email) || String.IsNullOrEmpty(phone) || String.IsNullOrEmpty(address))
            {
                MessageBox.Show("Please enter all data.","Missing Data",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            else
            { 
                MessageBox.Show($"Register information of user\n" +
                                $"Name : {name}\n\r" +
                                $"Email : {email}\n\r" +
                                $"Phone : {phone}\n\r" +
                                $"Address: {address}", "Information", MessageBoxButtons.OK); 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
