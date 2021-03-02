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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            lblError.Visible = false;
            VerficationFunction();
           void VerficationFunction()
            {
                CheckInt(txtID);
                CheckTextBox(txtName);
                CheckTextBox(txtSurname);
                CheckTextBox(txtEmail);
                CheckTextBox(txtCont);
                CheckTextBox(txtAddress);
            }
           void CheckTextBox(TextBox tb)
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    lblError.Visible = true;
                        
                }
                else
                {
                    lblError.Visible = false;
                }
               
            }
            void CheckInt(TextBox tb)
            {
                string x = tb.Text;
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

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
        }

        private void btnPhone_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedCells.Count > 0) 
            {
                int selectedrowindex = dgvCustomers.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvCustomers.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["ClientID"].Value);
                string name = Convert.ToString(selectedRow.Cells["Name"].Value);
                string surname = Convert.ToString(selectedRow.Cells["Surname"].Value);
                string address = Convert.ToString(selectedRow.Cells["Address"].Value);
                string contact = Convert.ToString(selectedRow.Cells["Contact"].Value);
                string email = Convert.ToString(selectedRow.Cells["Email"].Value);
             

                UpdateClientForm umf = new UpdateClientForm();
                umf.SelectedValues(id, name, surname, address, contact, email);
                umf.FormClosed += new FormClosedEventHandler(ChildForm_Closed);
                umf.Show();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
           

            if (dgvCustomers.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvCustomers.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvCustomers.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["ClientID"].Value);
                string name = Convert.ToString(selectedRow.Cells["Name"].Value);


                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + id + " " + name + " from database ?", "DELETE", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Client c = new Client();
                    c.DeleteBLCustomer(int.Parse(id));
                    RefreshPage();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }

                


            }
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            RefreshPage();
        }
        private void ChildForm_Closed(object sender, FormClosedEventArgs e)
        {
            RefreshPage();
        }
        public void RefreshPage()
        {
            List<Client> getClientDate = new List<Client>();
            BindingSource bs = new BindingSource();

            getClientDate = new Client().GetCustomer();
            bs.DataSource = getClientDate;
            dgvCustomers.DataSource = bs;

            dgvCustomers.AutoResizeColumns();

          

        }
    }
}
