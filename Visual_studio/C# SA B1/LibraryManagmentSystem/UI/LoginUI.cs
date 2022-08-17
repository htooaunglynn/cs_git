using LibraryManagmentSystem.DAO;
using LibraryManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagmentSystem.UI
{
    public partial class LoginUI : Form
    {
        public LoginUI()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;

            UserService userService = new UserService();
            UserModel userModel=userService.GetUserListByUserNameAndPassword(userName, password);

            if(string.IsNullOrEmpty(userModel.UserName))
            {
                MessageBox.Show("Invalid UI!", "Error occur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                this.Hide();
                DashBoardUI dashBoardUI = new DashBoardUI();
                dashBoardUI.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginUI_Load(object sender, EventArgs e)
        {

        }

        private void LoginUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
