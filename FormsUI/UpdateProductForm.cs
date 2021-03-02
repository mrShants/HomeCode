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

namespace FormsUI
{
    public partial class UpdateProductForm : Form
    {
        public UpdateProductForm()
        {
            InitializeComponent();
        }
        
        private void UpdateProductForm_Load(object sender, EventArgs e)
        {
            lblYearError.Visible = false;
        }

        public void SelectedValues(string id, string name, string description, string yearModel, string price)
        {
            lblID.Text = id;
            txtName.Text = name;
            rtbDescription.Text = description;
            txtYearModel.Text = yearModel;
            txtPrice.Text = price;
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            string id = lblID.Text;
            string name = txtName.Text;
            string description = rtbDescription.Text;
            string yearModel = txtYearModel.Text;
            string price = txtPrice.Text;

            if (int.Parse(yearModel) < 1900 || int.Parse(yearModel) > 2020)
            {
                lblYearError.Visible = true;
            }
            else
            {
                lblYearError.Visible = false;
                Product p = new Product();

                p.UpdateBLProduct(id, name, description, yearModel, price);

               

                this.Close();
            }


           
        }

        private void txtYearModel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtYearModel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void winExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
