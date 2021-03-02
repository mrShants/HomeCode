using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;

namespace FormsUI
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormOrders_Load(object sender, EventArgs e)
        {


            RefreshPage();

        }
        private void ChildForm_Closed(object sender, FormClosedEventArgs e)
        {
            RefreshPage();
        }
        private void RefreshPage()
        {
            BindingSource bs = new BindingSource();

            DataTable getAllOrders = new OrdersDataHandler().GetOrders();

            bs.DataSource = getAllOrders;
            dgvOrders.DataSource = bs;
            dgvOrders.AutoResizeColumns();
        }
     

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
            UpdateOrderForm update = new UpdateOrderForm();
            update.Show();

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            if (txtClient.Text == "" || txtID.Text == "")
            {

                lblError.Visible = true;
            }
            if (txtClient.Text != "" || txtID.Text != "")
            {
                lblError.Visible = false;
                string x = txtID.Text;
                int value;
                if (int.TryParse(x, out value))
                {
                    lblIntError.Visible = false;
                   
                }
                else
                {
                    lblIntError.Visible = true;
                }


            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrderForm add = new AddOrderForm();
            add.FormClosed += new FormClosedEventHandler(ChildForm_Closed);
            add.Show();
        }
    }
}
