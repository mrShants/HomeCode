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
using System.Linq;
using System.Collections;

namespace FormsUI
{
    public partial class AddOrderForm : Form
    {
        public AddOrderForm()
        {
            InitializeComponent();
        }
        public long TotalPrice = 0;
        private string clientID = null;
        
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pnlTop.ClientRectangle,
              Color.FromArgb(18, 185, 248), 1, ButtonBorderStyle.Solid, 
              Color.FromArgb(18, 185, 248), 1, ButtonBorderStyle.Solid, 
              Color.FromArgb(18, 185, 248), 1, ButtonBorderStyle.Solid, 
              Color.FromArgb(18, 185, 248), 1, ButtonBorderStyle.Solid);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
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

        private void iconButton2_Click(object sender, EventArgs e)  //Form Validation is done here
        {
            lblCustError.Visible = false;
            bool Continue = true;

            string[] productsArr = lstProducts.Items.OfType<string>().ToArray();
            string[] configurationsArr = lstConfiguration.Items.OfType<string>().ToArray();
            string products = String.Join(",",productsArr);
            string configurations = String.Join(",", configurationsArr);
       
            
            VerficationFunction();
            ValidateProduct(products, configurations);
            
            void VerficationFunction()
            {
                
                List<string> input = new List<string>();
                input.Clear();
                input.Add(txtCusName.Text);
                input.Add(txtCusSurname.Text);
                input.Add(txtCusAddress.Text);
                input.Add(txtCusContact.Text);
                input.Add(txtCusEmail.Text);
                
                Validate(input);
                
              
            }
            void Validate(List<string> inputValid)                //Customer details is validated here
            {
              
                foreach (string input in inputValid)
                {
                 if (string.IsNullOrEmpty(input))
                    {
                        if ( dgvCustomers.SelectedCells.Count < 0)
                        {


                            lblCustError.Visible = true;
                            Continue = false;

                        }
                        else
                        {
                            int selectedrowindex = dgvCustomers.SelectedCells[0].RowIndex;
                            DataGridViewRow selectedRow = dgvCustomers.Rows[selectedrowindex];
                            clientID = Convert.ToString(selectedRow.Cells["ClientID"].Value);
                            
                        }
                        
                    }
             
                }             
            }
            void ValidateProduct(string product ,string configuration)                //Customer details is validated here
            {

               
                if (product == "" || configuration == "")
                {
                    Continue = false;
                }


            }
            if (Continue == true)
            {
                string name = txtCusName.Text;
                string surname = txtCusSurname.Text;
                string address = txtCusAddress.Text;
                string contact = txtCusContact.Text;
                string email = txtCusEmail.Text;
                string installationDate = dtpInstallationDate.Value.ToString("dd/MM/yyyy");
                DateTime orderDate = DateTime.Now;     
                string orderPrice = lblTotalAmount.Text;
              
              
              //Values are passed through

                Orders o = new Orders();
                o.insertBLOrder(products, configurations, clientID, orderDate, installationDate , orderPrice);

                //Client c = new Client();
                //c.InsertBLCustomer(CusID, name, surname, address, contact, email, activeContract);

            }
          
        }

        private void AddOrderForm_Load(object sender, EventArgs e)  
        {
            RefreshPage();
        }
        public void RefreshPage() //---------------------------------------------------------------------Page Refresh here
        {
            //Retrieves product Data
            List<Product> productData = new List<Product>();
            BindingSource bs = new BindingSource();
            lstProducts.Items.Clear();

            Product pd = new Product();

            productData = pd.GetBLProduct();
            bs.DataSource = productData;

            dgvProduct.DataSource = bs;
            dgvProduct.Columns[0].Visible = false;
            dgvProduct.Columns[2].Visible = false;
            dgvProduct.Columns[3].Visible = false;
            dgvProduct.AutoResizeColumns();


            //Retrieves Configuration Data

            List<Configuration> confData = new List<Configuration>();
            BindingSource bsConf = new BindingSource();
            lstConfiguration.Items.Clear();

            Configuration c = new Configuration();

            confData = c.GetBLConfiguration();
            bsConf.DataSource = confData;

            dgvConfiguration.DataSource = bsConf;
            dgvConfiguration.Columns[0].Visible = false;
            dgvConfiguration.Columns[2].Visible = false;

            //Retrieves Client Data

            List<Client> clientData = new List<Client>();

            Client client = new Client();

            clientData = client.GetCustomer();
            dgvCustomers.DataSource = clientData;
            dgvCustomers.AutoResizeColumns();
            dgvCustomers.Columns[0].Visible = false;
            dgvCustomers.Columns[3].Visible = false;
            dgvCustomers.Columns[4].Visible = false;
            dgvCustomers.Columns[5].Visible = false;
            dgvCustomers.Columns[6].Visible = false;
            dgvCustomers.Columns[7].Visible = false;

            //Retrieves ClientUID

            int clientSerial = dgvCustomers.RowCount + 1;
            UIDGenerator g = new UIDGenerator();
            clientID = g.GenerateCustomerUID(clientSerial);

           

        }


      

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel2.ClientRectangle,
             Color.FromArgb(18, 185, 248), 2, ButtonBorderStyle.Solid,
             Color.FromArgb(18, 185, 248), 2, ButtonBorderStyle.Solid,
             Color.FromArgb(18, 185, 248), 2, ButtonBorderStyle.Solid,
             Color.FromArgb(18, 185, 248), 2, ButtonBorderStyle.Solid);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string searchValue = txtSearchProduct.Text;

            if (string.IsNullOrEmpty(searchValue))
            {
                MessageBox.Show("Please enter a name to search");
            }
            else
            {

                dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in dgvProduct.Rows)
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

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            if (dgvProduct.SelectedCells.Count > 0)
            {

                int selectedrowindex = dgvProduct.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvProduct.Rows[selectedrowindex];
                string name = Convert.ToString(selectedRow.Cells["Name"].Value);
                string price = Convert.ToString(selectedRow.Cells["Price"].Value);
                string addOrder = name + "  R" + price;


                lstProducts.Items.Add(addOrder);
                long totalProductPrice = 0;
                totalProductPrice += long.Parse(price);
                CalculateTotal(totalProductPrice);
                dgvProduct.ClearSelection();
            }
        }

        public void CalculateTotal(long itemPrice)
        {
            
            TotalPrice += itemPrice;
            lblTotalAmount.Text = TotalPrice.ToString();
            
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

        private void btnAddConfiguration_Click(object sender, EventArgs e)
        {
            if (dgvConfiguration.SelectedCells.Count > 0)
            {

                int selectedrowindex = dgvConfiguration.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvConfiguration.Rows[selectedrowindex];
                string type = Convert.ToString(selectedRow.Cells["Type"].Value);
                string price = Convert.ToString(selectedRow.Cells["Price"].Value);
                string addOrder = type + "  R" + price;

                lstConfiguration.Items.Add(addOrder);
                long totalConfPrice = 0;
                totalConfPrice += long.Parse(price);
                CalculateTotal(totalConfPrice);
            }
        }
    }
}
