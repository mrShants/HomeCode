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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

                
        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            if (txtName.Text == "" || txtID.Text == "")
            {

                lblError.Visible = true;
            }
            if (txtName.Text != "" || txtID.Text != "")
            {
                lblError.Visible = false;
                string x = txtID.Text;
                int value;
                if (int.TryParse(x, out value))
                {
                    lblIntError.Visible = false;
                    dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    try
                    {
                        foreach (DataGridViewRow row in dgvProducts.Rows)
                        {
                            if (row.Cells[1].Value.ToString().Contains(txtName.Text))
                            {
                                row.Selected = true;
                                break;
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }

                }
                else
                {
                    lblIntError.Visible = true;
                }


            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
            if (dgvProducts.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvProducts.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvProducts.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["ProductID"].Value);
                string name = Convert.ToString(selectedRow.Cells["Name"].Value);
                string description = Convert.ToString(selectedRow.Cells["Description"].Value);
                string yearModel = Convert.ToString(selectedRow.Cells["YearModel"].Value);
                string price = Convert.ToString(selectedRow.Cells["Price"].Value);
           

                UpdateProductForm umf = new UpdateProductForm();
                umf.SelectedValues(id, name, description, yearModel, price);
                umf.FormClosed += new FormClosedEventHandler(child_FormClosed);
                umf.Show();
            }
        }
        private void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshPage();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
            if (dgvProducts.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }

            if (dgvProducts.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvProducts.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvProducts.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["ProductID"].Value);
                string name = Convert.ToString(selectedRow.Cells["Name"].Value);
               

                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete " + id + " " + name  + " from database ?", "DELETE", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Product p = new Product();
                    p.DeleteBLProduct(id);
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }

                RefreshPage();


            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int serialNum = dgvProducts.RowCount;
            AddProductForm apf = new AddProductForm();
            apf.assignProductNo(serialNum);
            apf.FormClosed += new FormClosedEventHandler(child_FormClosed);
            
            apf.Show();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {

            RefreshPage();
        }
        public void RefreshPage()
        {
            Product p = new Product();
            List<Product> productData = new List<Product>();

            BindingSource bs = new BindingSource();

            productData = p.GetBLProduct();
            bs.DataSource = productData;
            dgvProducts.DataSource = bs;
            dgvProducts.AutoResizeColumns();
            dgvProducts.ClearSelection();
            
        }
     
    }
}
