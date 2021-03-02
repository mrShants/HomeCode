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
    public partial class AddManagementFrom : Form
    {
        public AddManagementFrom()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void winExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void winMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            string name = txtEmpName.Text;
           string surname = txtEmpSurname.Text;
            string email = txtEmpEmail.Text;
            string contact = txtEmpContact.Text;
            string position = txtEmpPostion.Text;
           string salary = txtEmpSalary.Text;

             new Employee().InsertBLEmployee(name,surname,email,contact,position,salary);

            new Main().RefreshManagementForm();
           

            this.Close();
           
        }

        private void txtEmpSalary_KeyPress(object sender, KeyPressEventArgs e)
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
