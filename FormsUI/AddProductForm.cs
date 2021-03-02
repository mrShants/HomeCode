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
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void winExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void winMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            int serial = int.Parse(lblSerial.Text);
            string name = txtName.Text;
            string description = rtbDescription.Text;
            string yearModel = txtYearModel.Text;
            string price = txtPrice.Text;
            string manu = null;

            if(cmbManu.Text.ToLower() == "securetech")
            {
                manu = "M";
            }
            if (cmbManu.Text.ToLower() == "heatdetectives")
            {
                manu = "N";
            }
            if (cmbManu.Text.ToLower() == "opticaldocters")
            {
                manu = "O";
            }
            if (cmbManu.Text.ToLower() == "easytech")
            {
                manu = "P";
            }
            if (cmbManu.Text.ToLower() == "futuresecure")
            {
                manu = "R";
            }

            UIDGenerator gen = new UIDGenerator();

            string productUID = gen.GenerateProductUID(serial, manu, yearModel);

            Product p = new Product();
            p.InsertBLProduct(productUID,name, description, yearModel, price);

            this.Close();

        }
         
        public void assignProductNo(int prodNo)
        {
            lblSerial.Text = prodNo.ToString();
        }
       

        private void txtYearModel_KeyPress(object sender, KeyPressEventArgs e)  //key press validate
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

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
