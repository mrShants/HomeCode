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
    public partial class AddClientForm : Form
    {
        public AddClientForm()
        {
            InitializeComponent();
        }
        public int serialClient;

        private void winMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void winExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddClientForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3),
                          this.DisplayRectangle);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtCusName.Text;
            string surname = txtCusSurname.Text;
            string contact = txtCusContact.Text;
            string address = txtCusAddress.Text;
            string email = txtCusEmail.Text;
            string activeContract = "NO";
            string contractExpiration = null ;

            Validator v = new Validator();
            bool valid = v.VailidateString(name);
            if (valid == true)
            {
                UIDGenerator ug = new UIDGenerator();
                string CusID = ug.GenerateCustomerUID(serialClient);
                Client c = new Client();

                c.InsertBLCustomer(CusID, name, surname, address, contact, email, activeContract);
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
           

           

       

        }
        public void assignSerial(int serial)
        {
            serialClient = serial+1; 
        }

        private void AddClientForm_Load(object sender, EventArgs e)
        {

        }

        private void txtCusContact_KeyPress(object sender, KeyPressEventArgs e)
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
