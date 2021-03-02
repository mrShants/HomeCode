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
    public partial class UpdateContractForm : Form
    {
        public UpdateContractForm()
        {
            InitializeComponent();
        }
        public string ContractUID;
        public string ContractType;
        public int MonthlyPrice;

        private void UpdateContractForm_Load(object sender, EventArgs e)
        {
            if (ContractType == "Complete Coverage")
            {
                MessageBox.Show("There are not upgrade options for this Contract Type!");
                this.Close();
            }
            if (ContractType == "High Class")
            {
                cmbUpgrade.Items.Add("Complete Coverage");
                
            }
            if (ContractType == "Defense Contract")
            {
                cmbUpgrade.Items.Add("High Class");
                cmbUpgrade.Items.Add("Complete Coverage");
                
            }
            if (ContractType == "Basic")
            {
                cmbUpgrade.Items.Add("High Class");
                cmbUpgrade.Items.Add("Complete Coverage");
                cmbUpgrade.Items.Add("DefenseContract");
               

            }
            if (ContractType == "Home Contract")
            {
                cmbUpgrade.Items.Add("High Class");
                cmbUpgrade.Items.Add("Complete Coverage");
                cmbUpgrade.Items.Add("DefenseContract");
                cmbUpgrade.Items.Add("Basic");
                
            }
        }
        public void getUpgradeValues(string contractID, string type, string monthlyCost)
        {
            ContractUID = contractID;
            ContractType = type;
            MonthlyPrice = int.Parse(monthlyCost);

        }

        private void cmbUpgrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            double NewPrice = (MonthlyPrice + (10 * MonthlyPrice / 100));
            lblMonthlyPrice.Text = (Math.Floor(NewPrice)).ToString();
        }

        private void winExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string newContractType = cmbUpgrade.Text;
            int newPrice = int.Parse(lblMonthlyPrice.Text);

            Contract cr = new Contract();
            cr.UpdateBLContract(ContractUID, newContractType, newPrice);
            this.Close();

        }
    }
}
