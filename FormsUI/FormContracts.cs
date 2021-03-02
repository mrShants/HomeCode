using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BusinessLogicLayer;

namespace FormsUI
{
    public partial class FormContracts : Form
    {
        public FormContracts()
        {
            InitializeComponent();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            int serialNum = dgvContracts.RowCount+1;


            AddContractForm acf = new AddContractForm();
            acf.ObtainSerial(serialNum);
            acf.Show();
            acf.FormClosed += new FormClosedEventHandler(child_FormClosed);

        }
        private void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            Refresh();
        }

        private void FormContracts_Load(object sender, EventArgs e)
        {
            Refresh();
            
        }

        private void Refresh()
        {
            Contract c = new Contract();
            List<Contract> readContractData = new List<Contract>();
            readContractData = c.GetBLContract();

            dgvContracts.DataSource = readContractData;
            dgvContracts.AutoResizeColumns();
        }

        private void btnServiceLevels_Click(object sender, EventArgs e)
        {
            Service s = new Service();
            List<Service> readServiceData = new List<Service>();
            readServiceData = s.GetBLService();

            dgvContracts.DataSource = readServiceData;
            dgvContracts.AutoResizeColumns();

            
            btnUpdateContract.Visible = false;
           
        }

        private void lblActiveContracts_Click(object sender, EventArgs e)
        {
            Refresh();

          
            btnAddContractType.Visible = false;

            btnUpdateContract.Visible = true;
            
        }

        private void btnContractTypes_Click(object sender, EventArgs e)
        {
            ContractType ct = new ContractType();
            List<ContractType> readContractTypeData = new List<ContractType>();
            readContractTypeData = ct.GetBLContractType();

            btnUpdateContract.Visible = false;
          
           
            btnAddContractType.Visible = true;

            dgvContracts.DataSource = readContractTypeData;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a name to search");
            }
            else
            {

                dgvContracts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in dgvContracts.Rows)
                    {
                        if (row.Cells[1].Value.ToString().Contains(searchValue))
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
        }

        private void btnUpdateContract_Click(object sender, EventArgs e)
        {
            if (dgvContracts.SelectedCells.Count > 0)
            {


                int selectedrowindex = dgvContracts.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvContracts.Rows[selectedrowindex];
                string contractUID = Convert.ToString(selectedRow.Cells["ContractID"].Value);
                string contractType = Convert.ToString(selectedRow.Cells["Type"].Value);
                string monthlyPrice = Convert.ToString(selectedRow.Cells["TotalMonthlyPrice"].Value);

                UpdateContractForm ucf = new UpdateContractForm();
                ucf.getUpgradeValues(contractUID, contractType, monthlyPrice);
                ucf.Show();

                ucf.FormClosed += new FormClosedEventHandler(child_FormClosed);

            }
            else
            {
                MessageBox.Show("Please select a contract to upgrade!");
            }


        }
    }
}
