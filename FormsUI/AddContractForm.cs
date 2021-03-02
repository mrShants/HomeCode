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
    public partial class AddContractForm : Form
    {
        public AddContractForm()
        {
            InitializeComponent();
        }
        public double TotalPrice = 0;
        public char representer = 'A';
        public int serial = 0;

        private void winMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void winExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnAddTech_Click(object sender, EventArgs e)
        {
            int serialClient = dgvClients.RowCount;
            AddClientForm acf = new AddClientForm();
            acf.assignSerial(serialClient);
            acf.Show();
            acf.FormClosed += new FormClosedEventHandler(child_FormClosed);

        }
        private void child_FormClosed(object sender, FormClosedEventArgs e)
        {
            Refresh();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle,
            Color.FromArgb(18, 185, 248), 2, ButtonBorderStyle.Solid,
            Color.FromArgb(18, 185, 248), 2, ButtonBorderStyle.Solid,
            Color.FromArgb(18, 185, 248), 2, ButtonBorderStyle.Solid,
            Color.FromArgb(18, 185, 248), 2, ButtonBorderStyle.Solid);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel3.ClientRectangle,
           Color.FromArgb(18, 185, 248), 2, ButtonBorderStyle.Solid,
           Color.FromArgb(18, 185, 248), 2, ButtonBorderStyle.Solid,
           Color.FromArgb(18, 185, 248), 2, ButtonBorderStyle.Solid,
           Color.FromArgb(18, 185, 248), 2, ButtonBorderStyle.Solid);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel4.ClientRectangle,
           Color.FromArgb(18, 185, 248), 2, ButtonBorderStyle.Solid,
           Color.FromArgb(18, 185, 248), 2, ButtonBorderStyle.Solid,
           Color.FromArgb(18, 185, 248), 2, ButtonBorderStyle.Solid,
           Color.FromArgb(18, 185, 248), 2, ButtonBorderStyle.Solid);
        }

        private void AddContractForm_Load(object sender, EventArgs e)
        {

            Refresh();

        }
        public void ObtainSerial(int serialNum)
        {
            serial = serialNum;
        }

        private void Refresh()
        {
            Service s = new Service();
            Client c = new Client();
            Product p = new Product();
            ContractType ct = new ContractType();

            List<Service> serviceData = new List<Service>();
            List<Client> clientData = new List<Client>();
            List<Product> productData = new List<Product>();
            List<ContractType> contractTypeData = new List<ContractType>();

            serviceData = s.GetBLService();
            clientData = c.GetCustomer();
            productData = p.GetBLProduct();
            contractTypeData = ct.GetBLContractType();

            dgvServices.DataSource = serviceData;
            dgvClients.DataSource = clientData;
            dgvProducts.DataSource = productData;
            dgvContractTypes.DataSource = contractTypeData;

            dgvServices.Columns[0].Visible = false;
            dgvServices.Columns[4].Visible = false;
            dgvServices.Columns[5].Visible = false;
            dgvServices.ClearSelection();
            

            dgvClients.Columns[0].Visible = false;
            dgvClients.ClearSelection();

            dgvProducts.Columns[0].Visible = false;
            dgvProducts.Columns[2].Visible = false;
            dgvProducts.Columns[3].Visible = false;
            dgvProducts.ClearSelection();

            dgvContractTypes.Columns[0].Visible = false;
            dgvContractTypes.Columns[5].Visible = false;
            dgvContractTypes.ClearSelection();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            bool dgvValidator = false;
            string customerUID = null;
            string customerName = null;
            string customerSurname = null;
            string customerAddress = null;
            string activeContract = null;
            string expirationDate = null;
            string contractName = null;
            string monthlyPrice = null;
            string contractTerm = null;
            string products = null;
            string representedSChar = null;
            string serviceName = null;
            string maintenancePlan = null;
            string servicePrice = null;
            string installationDate = null;
            string representedCChar = null;

            if (dgvClients.SelectedCells.Count > 0)
            {
                

                int selectedrowindex = dgvClients.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvClients.Rows[selectedrowindex];
                customerUID = Convert.ToString(selectedRow.Cells["ClientID"].Value);
                 customerName = Convert.ToString(selectedRow.Cells["Name"].Value);
                 customerSurname = Convert.ToString(selectedRow.Cells["Surname"].Value);
                 customerAddress = Convert.ToString(selectedRow.Cells["Address"].Value);
                 activeContract = Convert.ToString(selectedRow.Cells["ActiveContract"].Value);
                 expirationDate = Convert.ToString(selectedRow.Cells["ContractExpiration"].Value);

            }
            else
            {
                dgvValidator = true;
            }
            if (dgvContractTypes.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvContractTypes.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvContractTypes.Rows[selectedrowindex];
                 contractName = Convert.ToString(selectedRow.Cells["ContractName"].Value);
                 monthlyPrice = Convert.ToString(selectedRow.Cells["MonthlyPrice"].Value);
                 contractTerm = Convert.ToString(selectedRow.Cells["ContractTerm"].Value);
                 products = Convert.ToString(selectedRow.Cells["Products"].Value);
                 representedCChar = Convert.ToString(selectedRow.Cells["RepresentedChar"].Value);

            }
            else
            {
                dgvValidator = true;
            }
            if (dgvServices.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvServices.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvServices.Rows[selectedrowindex];
                 serviceName = Convert.ToString(selectedRow.Cells["ServiceName"].Value);
                 maintenancePlan = Convert.ToString(selectedRow.Cells["MaintenancePlan"].Value);
                 servicePrice = Convert.ToString(selectedRow.Cells["ServicePrice"].Value);
                 installationDate = Convert.ToString(selectedRow.Cells["installationDate"].Value);
                 representedSChar = Convert.ToString(selectedRow.Cells["RepresentedChar"].Value);
            }
            else
            {
                dgvValidator = true;
            }

            if(dgvValidator == true)
            {
                MessageBox.Show("Please select all values that should be included in Contract!");
            }
            else
            {
                DateTime dateInstalled = new DateTime();

                dateInstalled = dtpInstallationdate.Value;

                UIDGenerator ug = new UIDGenerator();

                if (activeContract[0] == 'N')
                {
                    char termChar = contractTerm[0];
                    int termAmount = termChar - '0';

                    string newExpirationDate = dateInstalled.AddYears(termAmount).ToString("dd/MM/yyyy");

                    string contractUID = ug.GenerateContractUID(representedCChar, representedSChar, serial, dateInstalled);


                    ContractRapportForm crf = new ContractRapportForm();
                    crf.ObtainContractDetails(contractUID, contractName, contractTerm, products, serviceName, dateInstalled.ToString("dd/MM/yyyy"), newExpirationDate, maintenancePlan, monthlyPrice, servicePrice, customerName, customerSurname, customerAddress, customerUID);
                    crf.Show();
                    crf.FormClosed += new FormClosedEventHandler(child_FormClosed);



                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show(@"You can only have one active contract at a time !
Would u like add this contract on a future period ?", "Active Contract", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        dateInstalled = DateTime.Parse(expirationDate).AddDays(1);
                        char termChar = contractTerm[0];
                        int termAmount = termChar - '0';
                        string newExpirationDate = dateInstalled.AddYears(termAmount).ToString("dd/MM/yyyy");

                        string contractUID = ug.GenerateContractUID(representedCChar, representedSChar, serial, dateInstalled);
                        ContractRapportForm crf = new ContractRapportForm();
                        crf.ObtainContractDetails(contractUID, contractName, contractTerm, products, serviceName, dateInstalled.ToString("dd/MM/yyyy"), newExpirationDate, maintenancePlan, monthlyPrice, servicePrice, customerName, customerSurname, customerAddress, customerUID);

                        crf.Show();
                        crf.FormClosed += new FormClosedEventHandler(child_FormClosed);
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
            }
            

           

           

        }
        private void btnAddContractType_Click(object sender, EventArgs e)
        {


            string contractName = txtContractName.Text;
            string contractTerm = cmbContractTerm.Text;

            string[] productsArr = lstProducts.Items.OfType<string>().ToArray();
            string products = String.Join(",", productsArr);

            

            
            char valueRep = representer;
           
            for (int i = 0; i <= dgvContractTypes.RowCount -1; i ++)
            {
                valueRep ++;
            }

            Validator v = new Validator();
            bool valid= v.VailidateString(contractName);

            if(valid == true)
            {
                ContractType ct = new ContractType();
                int monthlyCost = int.Parse(lblMonthlyPrice.Text);
                ct.InsertBLContractType(contractName, monthlyCost, contractTerm, products, valueRep.ToString());
            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
            

            txtContractName.Clear();
            cmbContractTerm.Text = null;
            lblMonthlyPrice.Text = null;


            Refresh();

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            double totalProductPrice = 0;

            if (dgvProducts.SelectedCells.Count > 0)
            {

                int selectedrowindex = dgvProducts.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvProducts.Rows[selectedrowindex];
                string name = Convert.ToString(selectedRow.Cells["Name"].Value);
                string price = Convert.ToString(selectedRow.Cells["Price"].Value);
                string addOrder = name + "  R" + price;


                lstProducts.Items.Add(addOrder);
                double selectedPrice = double.Parse(price);
                totalProductPrice += selectedPrice;
                CalculateMonthlyFees(totalProductPrice);
                dgvProducts.ClearSelection();
            }
            else
            {
                MessageBox.Show("Please select a product!");
            }

        }

        private void CalculateMonthlyFees(double calcPrice)
        {
            TotalPrice += calcPrice;
            string contractDuration = cmbContractTerm.Text;
            double monthlyPrice =0;

            if (contractDuration.ToLower() == "1 year")
            {
                monthlyPrice = (TotalPrice / 12);
                
            }
            if (contractDuration.ToLower() == "2 year")
            {
                monthlyPrice = (TotalPrice / 24);
            }
            if (contractDuration.ToLower() == "5 year")
            {
                monthlyPrice = (TotalPrice / 60);
            }
            if (contractDuration.ToLower() == "7 year")
            {
                monthlyPrice = (TotalPrice / 84);
            }

            int monthlyPriceRound = (int)monthlyPrice;

            lblMonthlyPrice.Text = monthlyPriceRound.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstProducts.Items.Clear();
            TotalPrice = 0;
            lblMonthlyPrice.Text = null;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
