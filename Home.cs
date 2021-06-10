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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            using (FrmOrder orders = new FrmOrder())
            {
                orders.ShowDialog();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            using (FrmOrder orders = new FrmOrder())
            {
                orders.ShowDialog();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            using (FrmMenu menu = new FrmMenu())
            {
                menu.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (FrmMenu menu = new FrmMenu())
            {
                menu.ShowDialog();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            using (FrmDelivery delivery = new FrmDelivery())
            {
                delivery.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (FrmDelivery delivery = new FrmDelivery())
            {
                delivery.ShowDialog();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
