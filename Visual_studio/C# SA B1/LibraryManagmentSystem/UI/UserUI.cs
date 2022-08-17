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
    public partial class UserUI : Form
    {
        public UserUI()
        {
            InitializeComponent();
        }

        private void UserUI_Load(object sender, EventArgs e)
        {

        }

        private void UserUI_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Application.Exit();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            try
            {
                string password = txtPassword.Text;
                string comfirmPassword = txtComfirmPassword.Text;

                if (password == comfirmPassword)
                {
                    UserModel userModel = new UserModel();

                    userModel.Id = Guid.NewGuid().ToString();
                    userModel.UserName = txtUserName.Text;
                    userModel.Email = txtEmail.Text;
                    userModel.Password = password;

                    if (rdoAdmin.Checked)
                    {
                        userModel.Role = rdoAdmin.Text;
                    }
                    else if (rdoStuff.Checked)
                    {
                        userModel.Role = rdoStuff.Text;
                    }

                    UserService userService = new UserService();
                    try
                    {
                        userService.SaveUser(userModel);
                        MessageBox.Show("Save Success.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Save fail.");
                    }
                    
                }

                else
                {
                    MessageBox.Show("Password and Comfirm password does not match.", "Error occur!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something wrong.", "Error occur!");
            }
        }
    }
}
