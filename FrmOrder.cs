using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace PizzaOrder
{
    public partial class FrmOrder : Form
    {
        public static string setvaluetext1;
        public static string setvaluetext2;
        public static string setvaluetext3;
        public static string setvaluetext4;
        public static string setvaluetext5;
        public static string setvaluetext6;
        public static string setvaluetext7;
        public static string setvaluetext8;
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.DataSource = UsersDetails.orderInfos.ToList();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool isEditing = false;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OrderInfo orderInfo = new OrderInfo();
            int id;
            if (int.TryParse(txtOrderNo.Text, out id))
            {
                orderInfo.OrderNo = id;
            }



            if (txtName.Text != "")
            {
                orderInfo.Name = txtName.Text;
            }
            else
            {
                MessageBox.Show("You have to give us your name!");
                return;
            }
            if (txtLastName.Text != "")
            {
                orderInfo.LastName = txtLastName.Text;
            }
            else
            {
                MessageBox.Show("You have to give us your last name!");
                return;
            }
            if (txtAddress.Text != "")
            {
                orderInfo.Address = txtAddress.Text;
            }
            else
            {
                MessageBox.Show("You have to give us your address!");
                return;
            }
            if (comboCity.Text != "")
            {
                orderInfo.City = comboCity.Text;
            }
            else
            {
                MessageBox.Show("You have to choose a city!");
                return;
            }
            orderInfo.Number = txtNumber.Text;


            if (txtEmail.Text != "")
            {
                orderInfo.Email = txtEmail.Text;
            }
            else
            {
                MessageBox.Show("You have to give us your email!");
                return;
            }

            double Amount;
            if (double.TryParse(txtTotal.Text, out Amount))
            {
                orderInfo.TotalAmount = Amount;
            }
            else
            {
                MessageBox.Show("Your total amount is not valid!");
                return;
            }


            if (!isEditing)
            {

                UsersDetails.orderInfos.Add(orderInfo);
            }
            else
            {
                OrderInfo row = UsersDetails.orderInfos.Where(t => t.OrderNo == id).FirstOrDefault();
                row.Name = orderInfo.Name;
                row.LastName = orderInfo.LastName;
                row.Address = orderInfo.Address;
                row.City = orderInfo.City;
                row.Number = orderInfo.Number;
                row.Email = orderInfo.Email;
                row.TotalAmount = orderInfo.TotalAmount;
            }

            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.DataSource = UsersDetails.orderInfos.ToList();

            txtOrderNo.Text = "";
            txtName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            comboCity.Text = "";
            txtNumber.Text = "";
            txtEmail.Text = "";
            txtTotal.Text = "";
            isEditing = false;
            txtOrderNo.Enabled = true;
        }

        private void lblHere_Click(object sender, EventArgs e)
        {
            //Pizza Type Selection 

            if (radioSmall.Checked == true)
            {
                if (radioNormal.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("2.50");
                    listViewOrder.Items.Add(item);


                }
                else if (radioCheesy.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Small Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("2.50");
                    listViewOrder.Items.Add(item);

                }
            }

            else if (radioMedium.Checked == true)
            {
                if (radioNormal.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("5.00");
                    listViewOrder.Items.Add(item);

                }
                else if (radioCheesy.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Medium Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("5.00");
                    listViewOrder.Items.Add(item);

                }
            }

            else if (radioLarge.Checked == true)
            {
                if (radioNormal.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Normal Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("8.00");
                    listViewOrder.Items.Add(item);

                }
                else if (radioCheesy.Checked == true)
                {
                    ListViewItem item = new ListViewItem("Cheesy Crust Large Pizza");
                    item.SubItems.Add("1");
                    item.SubItems.Add("8.00");
                    listViewOrder.Items.Add(item);

                }

            }

            //Pizza Topping Selection

            if (checkPepperoni.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Pepperoni Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.50");
                listViewOrder.Items.Add(item);

            }

            if (checkExtraCheese.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Extra Cheese Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.50");
                listViewOrder.Items.Add(item);

            }

            if (checkMushrooms.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Mushroom Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.50");
                listViewOrder.Items.Add(item);

            }

            if (checkHam.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Ham Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.50");
                listViewOrder.Items.Add(item);

            }

            if (checkBeef.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Beef Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.50");
                listViewOrder.Items.Add(item);

            }

            if (checkChicken.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Chicken Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.50");
                listViewOrder.Items.Add(item);

            }

            if (checkShrimps.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Shrimps Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.50");
                listViewOrder.Items.Add(item);

            }

            if (checkTunaFish.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Tuna Fish Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.50");
                listViewOrder.Items.Add(item);

            }

            if (checkTomatoes.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Tomatoes Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.50");
                listViewOrder.Items.Add(item);

            }

            if (checkOlives.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Olives Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.50");
                listViewOrder.Items.Add(item);

            }

            if (checkHotPeppers.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Hot Peppers Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.50");
                listViewOrder.Items.Add(item);

            }

            if (checkSpinach.Checked == true)
            {
                ListViewItem item = new ListViewItem("  Spinach Toppings");
                item.SubItems.Add("");
                item.SubItems.Add("0.50");
                listViewOrder.Items.Add(item);

            }


            //Drink Selection

            if (checkCocaCola.Checked == true)
            {
                ListViewItem item = new ListViewItem("Coca Cola");
                item.SubItems.Add(numericCC.Text);
                int quantity = Convert.ToInt32(numericCC.Text);
                double cost = quantity * 1.00;
                string Cost = cost.ToString();
                item.SubItems.Add(Cost);
                listViewOrder.Items.Add(item);

            }



            if (checkDietCocaCola.Checked == true)
            {
                ListViewItem item = new ListViewItem("Diet Coca Cola");
                item.SubItems.Add(numericDietCC.Text);
                int quantity = Convert.ToInt32(numericDietCC.Text);
                double cost = quantity * 1.00;
                string Cost = cost.ToString();
                item.SubItems.Add(Cost);
                listViewOrder.Items.Add(item);

            }



            if (checkFantaOrange.Checked == true)
            {
                ListViewItem item = new ListViewItem("Fanta Orange");
                item.SubItems.Add(numericFantaO.Text);
                int quantity = Convert.ToInt32(numericFantaO.Text);
                double cost = quantity * 1.00;
                string Cost = cost.ToString();
                item.SubItems.Add(Cost);
                listViewOrder.Items.Add(item);

            }



            if (checkFantaExotic.Checked == true)
            {
                ListViewItem item = new ListViewItem("Fanta Exotic");
                item.SubItems.Add(numericFantaE.Text);
                int quantity = Convert.ToInt32(numericFantaE.Text);
                double cost = quantity * 1.00;
                string Cost = cost.ToString();
                item.SubItems.Add(Cost);
                listViewOrder.Items.Add(item);

            }


            if (checkIcedTea.Checked == true)
            {
                ListViewItem item = new ListViewItem("Iced Tea");
                item.SubItems.Add(numericTea.Text);
                int quantity = Convert.ToInt32(numericTea.Text);
                double cost = quantity * 1.00;
                string Cost = cost.ToString();
                item.SubItems.Add(Cost);
                listViewOrder.Items.Add(item);

            }

            if (checkSprite.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sprite");
                item.SubItems.Add(numericSprite.Text);
                int quantity = Convert.ToInt32(numericSprite.Text);
                double cost = quantity * 1.00;
                string Cost = cost.ToString();
                item.SubItems.Add(Cost);
                listViewOrder.Items.Add(item);

            }




            //Other Items Selection

            if (checkWings.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chicken Wings");
                item.SubItems.Add(numericWings.Text);
                int quantity = Convert.ToInt32(numericWings.Text);
                double cost = quantity * 1.00;
                string Cost = cost.ToString();
                item.SubItems.Add(Cost);
                listViewOrder.Items.Add(item);

            }

            else
            {
                numericWings.Text = "";
            }

            if (checkNuggets.Checked == true)
            {
                ListViewItem item = new ListViewItem("Chicken Nuggets");
                item.SubItems.Add(numericNuggets.Text);
                int quantity = Convert.ToInt32(numericNuggets.Text);
                double cost = quantity * 1.00;
                string Cost = cost.ToString();
                item.SubItems.Add(Cost);
                listViewOrder.Items.Add(item);

            }

            else
            {
                numericNuggets.Text = "";
            }

            if (checkRings.Checked == true)
            {
                ListViewItem item = new ListViewItem("Onion Rings");
                item.SubItems.Add(numericRings.Text);
                int quantity = Convert.ToInt32(numericRings.Text);
                double cost = quantity * 1.00;
                string Cost = cost.ToString();
                item.SubItems.Add(Cost);
                listViewOrder.Items.Add(item);

            }

            else
            {
                numericRings.Text = "";
            }

            if (checkBBQ.Checked == true)
            {
                ListViewItem item = new ListViewItem("BBQ Sauce");
                item.SubItems.Add(numericBBQ.Text);
                int quantity = Convert.ToInt32(numericBBQ.Text);
                double cost = quantity * 1.00;
                string Cost = cost.ToString();
                item.SubItems.Add(Cost);
                listViewOrder.Items.Add(item);

            }

            else
            {
                numericBBQ.Text = "";
            }

            if (checkSour.Checked == true)
            {
                ListViewItem item = new ListViewItem("Sour Cream");
                item.SubItems.Add(numericSour.Text);
                int quantity = Convert.ToInt32(numericSour.Text);
                double cost = quantity * 1.00;
                string Cost = cost.ToString();
                item.SubItems.Add(Cost);
                listViewOrder.Items.Add(item);

            }

            else
            {
                numericSour.Text = "";
            }

            if (checkGarlic.Checked == true)
            {
                ListViewItem item = new ListViewItem("Garlic Sauce");
                item.SubItems.Add(numericGarlic.Text);
                int quantity = Convert.ToInt32(numericGarlic.Text);
                double cost = quantity * 1.00;
                string Cost = cost.ToString();
                item.SubItems.Add(Cost);
                listViewOrder.Items.Add(item);

            }

            else
            {
                numericGarlic.Text = "";
            }


            double total = 0;
            double tax = 0;
            double totaldue = 0;

            foreach (ListViewItem item in listViewOrder.Items)
            {
                total += Convert.ToDouble(item.SubItems[2].Text);
            }

            tax = total * 0.18;
            totaldue = tax + total;


            string totalDisplay = total.ToString("n2");
            string totaldueDisplay = totaldue.ToString("n2");

            txtBeforeTax.Text = totalDisplay;
            txtTotal.Text = totaldueDisplay;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();

            List<OrderInfo> result = UsersDetails.orderInfos.Where(
                t => t.Name.ToLower().StartsWith(searchText) ||
                   t.City.ToLower().StartsWith(searchText)).ToList();

            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.DataSource = result;
        }

        private void txtNumber_Validating(object sender, CancelEventArgs e)
        {
            Regex R = new Regex(@"\(\d{3}\)\d{4}-\d{4}");
            if (!R.IsMatch(txtNumber.Text))
            {
                MessageBox.Show("Be careful! Contact number should be written in this format: (111)1111-1111");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(txtEmail.Text.Trim());
            if (!isValid)
            {
                MessageBox.Show("Be careful! Email should be written in this format: abc@xyz.org");
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (txtOrderNo.Text == "" || txtName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" || comboCity.Text == "" || txtNumber.Text == "" || txtEmail.Text == "")
            {
                lblWarning1.Visible = true;
            }
            else
            {
                lblWarning1.Visible = false;
                tabControl1.SelectTab("tabPage2");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPage5");
            lblDue.Text = txtTotal.Text;
            btnSubmit.Enabled = false;
            toolStripStatusLabel1.Text = "After paying click on the label to get your change...";

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "You cannot submit order without paying first";
            if (lblChange.Text != "")
            {
                toolStripStatusLabel1.Text = "";


            }

            tabControl1.SelectTab("tabPage6");
            btnPay.Enabled=true;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            listViewOrder.Items.Clear();
            txtBeforeTax.Text = "";
            txtTotal.Text = "";
            radioSmall.Checked = false;
            radioMedium.Checked = false;
            radioLarge.Checked = false;
            radioNormal.Checked = false;
            radioCheesy.Checked = false;
            checkPepperoni.Checked = false;
            checkExtraCheese.Checked = false;
            checkMushrooms.Checked = false;
            checkHam.Checked = false;
            checkBeef.Checked = false;
            checkChicken.Checked = false;
            checkShrimps.Checked = false;
            checkTunaFish.Checked = false;
            checkTomatoes.Checked = false;
            checkOlives.Checked = false;
            checkHotPeppers.Checked = false;
            checkSpinach.Checked = false;
            checkCocaCola.Checked = false;
            numericCC.Value = 0;
            checkDietCocaCola.Checked = false;
            numericDietCC.Value = 0;
            checkFantaOrange.Checked = false;
            numericFantaO.Value = 0;
            checkFantaExotic.Checked = false;
            numericFantaE.Value = 0;
            checkIcedTea.Checked = false;
            numericTea.Value = 0;
            checkSprite.Checked = false;
            numericSprite.Value = 0;
            checkWings.Checked = false;
            numericWings.Value = 0;
            checkNuggets.Checked = false;
            numericNuggets.Value = 0;
            checkRings.Checked = false;
            numericRings.Value = 0;
            checkBBQ.Checked = false;
            numericBBQ.Value = 0;
            checkSour.Checked = false;
            numericSour.Value = 0;
            checkGarlic.Checked = false;
            numericGarlic.Value = 0;

            comboMethod.Text = "";
            txtCardNumber.Text = "";
            txtPaid.Text = "";
            lblChange.Text = "";

            tabControl1.SelectTab("tabPage1");
        }

        private void btnReorder_Click(object sender, EventArgs e)
        {
            listViewOrder.Items.Clear();
            tabControl1.SelectTab("tabPage2");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listViewOrder.Items.Clear();
            txtBeforeTax.Text = "";
            txtTotal.Text = "";
            radioSmall.Checked = false;
            radioMedium.Checked = false;
            radioLarge.Checked = false;
            radioNormal.Checked = false;
            radioCheesy.Checked = false;
            checkPepperoni.Checked = false;
            checkExtraCheese.Checked = false;
            checkMushrooms.Checked = false;
            checkHam.Checked = false;
            checkBeef.Checked = false;
            checkChicken.Checked = false;
            checkShrimps.Checked = false;
            checkTunaFish.Checked = false;
            checkTomatoes.Checked = false;
            checkOlives.Checked = false;
            checkHotPeppers.Checked = false;
            checkSpinach.Checked = false;
            checkCocaCola.Checked = false;
            numericCC.Value = 0;
            checkDietCocaCola.Checked = false;
            numericDietCC.Value = 0;
            checkFantaOrange.Checked = false;
            numericFantaO.Value = 0;
            checkFantaExotic.Checked = false;
            numericFantaE.Value = 0;
            checkIcedTea.Checked = false;
            numericTea.Value = 0;
            checkSprite.Checked = false;
            numericSprite.Value = 0;
            checkWings.Checked = false;
            numericWings.Value = 0;
            checkNuggets.Checked = false;
            numericNuggets.Value = 0;
            checkRings.Checked = false;
            numericRings.Value = 0;
            checkBBQ.Checked = false;
            numericBBQ.Value = 0;
            checkSour.Checked = false;
            numericSour.Value = 0;
            checkGarlic.Checked = false;
            numericGarlic.Value = 0;

            tabControl1.SelectTab("tabPage2");
        }

        private void btnSubmit_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void comboMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboMethod.Text == "Cash")
            {
                txtCardNumber.Enabled = false;
            }
            else
            {
                txtCardNumber.Enabled = true;
            }
        }

        private void lblChange_Click(object sender, EventArgs e)
        {
            double due = Convert.ToDouble(lblDue.Text);
            double pay = Convert.ToDouble(txtPaid.Text);
            double change = pay - due;
            lblChange.Text = Convert.ToString(change);
            if (change < 0)
            {

                MessageBox.Show("Please pay your balance!");
            }
        }

        private void btnSubmit_Leave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";

        }

        private void btnReady_Click(object sender, EventArgs e)
        {
            setvaluetext1 = txtOrderNo.Text;
            setvaluetext2 = txtName.Text;
            setvaluetext3 = txtLastName.Text;
            setvaluetext4 = txtAddress.Text;
            setvaluetext5 = comboCity.Text;
            setvaluetext6 = txtNumber.Text;
            setvaluetext7 = txtEmail.Text;
            setvaluetext8 = txtTotal.Text;

           
            using (FrmDelivery delivery = new FrmDelivery())
            {
                delivery.ShowDialog();
            }
            this.Hide();
        }

        private void dgvOrders_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                txtOrderNo.Text = dgvOrders.SelectedRows[0].Cells["OrderNo"].Value.ToString();
                txtName.Text = dgvOrders.SelectedRows[0].Cells["Name"].Value.ToString();
                txtLastName.Text = dgvOrders.SelectedRows[0].Cells["LastName"].Value.ToString();
                txtAddress.Text = dgvOrders.SelectedRows[0].Cells["Address"].Value.ToString();
                comboCity.Text = dgvOrders.SelectedRows[0].Cells["City"].Value.ToString();
                txtNumber.Text = dgvOrders.SelectedRows[0].Cells["Number"].Value.ToString();
                txtEmail.Text = dgvOrders.SelectedRows[0].Cells["Email"].Value.ToString();
                txtTotal.Text = dgvOrders.SelectedRows[0].Cells["TotalAmount"].Value.ToString();

                isEditing = true;
                txtOrderNo.Enabled = false;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (comboMethod.Text == "" || txtPaid.Text == "")
            {
                lblWarning.Visible = true;
                btnPay.Enabled = true;
                btnSubmit.Enabled = false;


            }
            else
            {

                lblWarning.Visible = false;
                btnPay.Enabled = false;
                btnSubmit.Enabled = true;
            }
        }

        private void txtOrderNo_Validating(object sender, CancelEventArgs e)
        {
            for (int item = 0; item < dgvOrders.Rows.Count; item++)
            {
                if (txtOrderNo.Text == dgvOrders.Rows[item].Cells[0].Value.ToString())
                {
                    MessageBox.Show("An order already exists with this ID!");
                    txtOrderNo.Focus();
                }

            }
        }

        private void txtOrderNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
                MessageBox.Show("ID is not valid. It should contain only numbers!");
                return;
            }
        }

        private void lblWarning_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
