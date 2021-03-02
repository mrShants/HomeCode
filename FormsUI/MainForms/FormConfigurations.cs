using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsUI
{
    public partial class FormConfigurations : Form
    {
        public FormConfigurations()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormConfigurations_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvConfi.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvConfi.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
        }

        private void btnSearchProd_Click(object sender, EventArgs e)
        {
            if (txtProdName.Text == "")
            {
                MessageBox.Show("Please enter product name to search");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvConfi.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvConfi.SelectedRows == null)
            {
                MessageBox.Show("Please Select A Row");
            }
        }

        private void btnSearchConf_Click(object sender, EventArgs e)
        {
            lblError.Visible = false;
            if (txtProdName.Text == "" || txtID.Text == "")
            {

                lblError.Visible = true;
            }
            if (txtProdName.Text != "" || txtID.Text != "")
            {
                lblError.Visible = false;
                string x = txtID.Text;
                int value;
                if (int.TryParse(x,out value))
                {
                    lblIntError.Visible = false;
                }
                else
                {
                    lblIntError.Visible = true;
                }
             
                
            }
        }

      
    }
}
