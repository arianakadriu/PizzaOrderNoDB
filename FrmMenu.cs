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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (FrmOrder orders = new FrmOrder())
            {
                orders.ShowDialog();
            }
            this.Close();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label11.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            label20.Visible = true;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            label21.Visible = true;
            label22.Visible = true;
            label23.Visible = true;
            label24.Visible = true;
            label33.Visible = true;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label25.Visible = true;
            label26.Visible = true;
            label27.Visible = true;
            label28.Visible = true;
            label30.Visible = true;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            label29.Visible = true;
            label31.Visible = true;
            label32.Visible = true;
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Hover on pictures of pizzas and sauces to view the ingredients!";

        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label11.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            label21.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label33.Visible = false;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label25.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label30.Visible = false;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            label29.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            label34.Visible = true;
            label35.Visible = true;
            label36.Visible = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
        }
    }
}
