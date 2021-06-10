using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrder
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            
            if (UsersDetails.users.Where(
                t => t.Username == txtUsername.Text &&
                t.Password == txtPassword.Text &&
                t.StatusId == 1).Count() > 0)
            {
                    
                Home main = new Home();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                lblWarning.Visible = true;
                lblTryAgain.Visible = true;
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        

     

        private void checkShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowHide.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            UsersDetails.LoadUsers();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblWarning_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
