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
    public partial class UpdateClientForm : Form
    {
        public UpdateClientForm()
        {
            InitializeComponent();
        }

        private void UpdateClientForm_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {

            string id = lblID.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string address = txtAddress.Text;
            string contact = txtContact.Text;
            string email = txtEmail.Text;

            Client c = new Client();
            c.UpdateBLCustomer(int.Parse(id), name, surname, address, contact, email);
            this.Close();
        }
        public void SelectedValues(string id,string name,string surname, string address, string contact, string email)
        {
            lblID.Text = id;
            txtName.Text = name;
            txtSurname.Text = surname;
            txtAddress.Text = address;
            txtContact.Text = contact;
            txtEmail.Text = email;
        }

        private void winExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
