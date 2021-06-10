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
    public partial class FrmDelivery : Form
    {
        public FrmDelivery()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            btnSubmit.Enabled = false;
            if (lblOrderNo.Text !=null || lblName.Text!= null ||lblLastName.Text!=null||lblAddress.Text!=null||lblCity.Text!=null||lblNumber.Text!=null||lblEmail.Text!=null||lblTotal.Text!=null)
            {
                btnSubmit.Enabled = true;
            }
            if (radioPick.Checked == true)
            {
                MessageBox.Show("Your delivery is ready in 20 minutes for pick up. Thank you for your order!"); 
            }
            if (radioHome.Checked==true)
            {
                MessageBox.Show("Your delivery will be at your home in 30 minutes. Thank you for your order!");
            }
            this.Close();
        }

        private void FrmDelivery_Load(object sender, EventArgs e)
        { 
            lblOrderNo.Text = FrmOrder.setvaluetext1;
            lblName.Text = FrmOrder.setvaluetext2;
            lblLastName.Text = FrmOrder.setvaluetext3;
            lblAddress.Text = FrmOrder.setvaluetext4;
            lblCity.Text = FrmOrder.setvaluetext5;
            lblNumber.Text = FrmOrder.setvaluetext6;
            lblEmail.Text = FrmOrder.setvaluetext7;
            lblTotal.Text = FrmOrder.setvaluetext8;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
