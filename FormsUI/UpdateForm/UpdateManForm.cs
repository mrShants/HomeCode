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
    public partial class UpdateManForm : Form
    {
        public UpdateManForm()
        {
            InitializeComponent();
        }

        private void winMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void winExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            int id = int.Parse(lblID.Text);
            string name = txtEmpName.Text;
            string surname = txtEmpSurname.Text;
            string email = txtEmpEmail.Text;
            int contact = int.Parse(txtEmpContact.Text);
            string position = txtEmpPostion.Text;
            double salary = double.Parse(txtEmpSalary.Text);

            Employee ep = new Employee();
            ep.UpdateBLEmployee(id, name, surname, email, contact, position, salary);
            this.Close();
        }
        

        public void SelectedValues(string id, string name, string surname, string email, string contact, string position, string salary)
        {
            lblID.Text = id;
            txtEmpName.Text = name;
            txtEmpSurname.Text = surname;
            txtEmpEmail.Text = email;
            txtEmpContact.Text = contact;
            txtEmpPostion.Text = position;
            txtEmpSalary.Text = salary;

        }

        private void UpdateManForm_Load(object sender, EventArgs e)
        {

        }

        private void txtEmpContact_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmpContact_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
