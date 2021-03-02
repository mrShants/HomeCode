using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BusinessLogicLayer;

namespace FormsUI
{
    public partial class FormManagement : Form
    {
  
        public FormManagement()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dgvTechTeam.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (dgvTechTeam.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvTechTeam.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvTechTeam.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["TechnicalID"].Value);
                string name = Convert.ToString(selectedRow.Cells["Name"].Value);
                string surname = Convert.ToString(selectedRow.Cells["Surname"].Value);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + id + " " + name + " " + surname + " from database ?", "DELETE", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TechnicalStaff ts = new TechnicalStaff();
                    ts.DeleteBLEmployee(int.Parse(id));
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }

                RefreshPage();

            }
        }

        private void iconButton4_Click(object sender, EventArgs e) // the rows that will be updating tech team
        {
            if (dgvTechTeam.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvTechTeam.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvTechTeam.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["TechnicalID"].Value);
                string name = Convert.ToString(selectedRow.Cells["Name"].Value);
                string surname = Convert.ToString(selectedRow.Cells["Surname"].Value);
                string specialization = Convert.ToString(selectedRow.Cells["Specialization"].Value);
                string deployed = Convert.ToString(selectedRow.Cells["Deployed"].Value);
                string deployementDate = Convert.ToString(selectedRow.Cells["DeploymentDate"].Value);
                

                UpdateTechForm utf = new UpdateTechForm();
                utf.SelectedTechValuess(id, name, surname, specialization, deployed, deployementDate);
                utf.FormClosed += new FormClosedEventHandler(ChildForm_Closed);
                utf.Show();
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dgvTechTeam.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchTech_Click(object sender, EventArgs e)
        {

            VerficationFunction();                              //Validation is done here
            void VerficationFunction()
            {
              
                CheckInt(txtTechID);
                CheckTextBox(txtTechName);
                CheckTextBox(txtTechSurname);
             
            }
            void CheckTextBox(TextBox tb)
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    MessageBox.Show("Please fill in all fields");

                }
             

            }
            void CheckInt(TextBox tb)
            {
                string x = tb.Text;
                int value;
                if (int.TryParse(x, out value))
                {
                    
                }
                else
                {
                    MessageBox.Show("ID Field should be an Integar");
                }
            }
        }

        private void btnUpMan_Click(object sender, EventArgs e)
        {
            if (dgvMan.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
        }

        private void btnDeleteMan_Click(object sender, EventArgs e)
        {
            if (dgvMan.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }

            if (dgvMan.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvMan.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvMan.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["EmployeeID"].Value);
                string name = Convert.ToString(selectedRow.Cells["Name"].Value);
                string surname = Convert.ToString(selectedRow.Cells["Surname"].Value);

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + id + " " + name + " " + surname + " from database ?", "DELETE", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Employee ep = new Employee();
                    ep.DeleteBLEmployee(int.Parse(id));
                 
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }

                RefreshPage();

            }
            

        }

        private void btnUpdateMan_Click(object sender, EventArgs e)    //Selects the rows values so that it can be updated.
        {
            if (dgvMan.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvMan.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvMan.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["EmployeeID"].Value);
                string name = Convert.ToString(selectedRow.Cells["Name"].Value);
                string surname = Convert.ToString(selectedRow.Cells["Surname"].Value);
                string email = Convert.ToString(selectedRow.Cells["Email"].Value);
                string contact = Convert.ToString(selectedRow.Cells["Contact"].Value);
                string position = Convert.ToString(selectedRow.Cells["Position"].Value);
                string salary = Convert.ToString(selectedRow.Cells["Salary"].Value);

                UpdateManForm umf = new UpdateManForm();
               
                umf.SelectedValues(id, name, surname, email, contact, position, salary);
                umf.FormClosed += new FormClosedEventHandler(ChildForm_Closed);
                umf.Show();
            }

          



        }

        private void btnDownMan_Click(object sender, EventArgs e)
        {
            if (dgvMan.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
        }

        private void btnSearchMan_Click(object sender, EventArgs e)
        {

        }

        public void FormManagement_Load(object sender, EventArgs e)
        {
            RefreshPage();
        
        }
        private void ChildForm_Closed(object sender, FormClosedEventArgs e)
        {
            RefreshPage();
        }
        public void RefreshPage()
        {
            List<Employee> emp = new List<Employee>();
            List<TechnicalStaff> ts = new List<TechnicalStaff>();

            BindingSource bs = new BindingSource();
            BindingSource bsTech = new BindingSource();

            emp = new Employee().GetEmployee();
            bs.DataSource = emp;
            dgvMan.DataSource = bs;
            dgvMan.AutoResizeColumns();

            ts = new TechnicalStaff().GetBLTechnical();
            bsTech.DataSource = ts;
            dgvTechTeam.DataSource = bsTech;
            dgvTechTeam.AutoResizeColumns();

        }

        private void btnAddMan_Click(object sender, EventArgs e)
        {
            AddManagementFrom manForm = new AddManagementFrom();
            manForm.FormClosed += new FormClosedEventHandler(ChildForm_Closed);
            manForm.Show();
        }

        private void btnAddTech_Click(object sender, EventArgs e)
        {
            AddTechnicalForm atf = new AddTechnicalForm();
            atf.FormClosed += new FormClosedEventHandler(ChildForm_Closed);
            atf.Show();
        }
    }
}
