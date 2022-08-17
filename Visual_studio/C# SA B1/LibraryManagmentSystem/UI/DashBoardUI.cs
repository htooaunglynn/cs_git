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
    public partial class DashBoardUI : Form
    {
        private int childFormNumber = 0;

        public DashBoardUI()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

       

       

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

      

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void DashBoardUI_Load(object sender, EventArgs e)
        {

        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();

            DialogResult dialogResult = MessageBox.Show("Are you sure to logout.", "Logout!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult==DialogResult.Yes)
            {
                this.Hide();
                LoginUI loginUI = new LoginUI();
                loginUI.Show(); 
            }
        } // end of logToolStripMenuItem_Click method

        private void DashBoardUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserUI userUI = new UserUI();
            userUI.MdiParent = this;   
            userUI.Show();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserListUI userListUI = new UserListUI();
            userListUI.MdiParent = this;
            userListUI.Show();
        }

        
    } // end of DashBoardUI class
} // end of namespace
