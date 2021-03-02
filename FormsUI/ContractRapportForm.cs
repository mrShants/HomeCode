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
    public partial class ContractRapportForm : Form
    {
        public ContractRapportForm()
        {
            InitializeComponent();
        }

        public string ClientUID;

        private void ContractRapportForm_Load(object sender, EventArgs e)
        {
           
        }
        public void ObtainContractDetails(string contactUID, string type, string term, string products, string serviceName, string installationDate, string expirationDate, string maintenancePlane, string MonthlyContractPrice, string MonthlyServicePrice, string clientName, string clientSurname, string clientAddress, string clientUID)
        {
            ClientUID = clientUID;
            lblUID.Text = contactUID;
            lblContractType.Text = type;
            lblTerm.Text = term;
            lblProducts.Text = products;
            lblService.Text = serviceName;
            lblinstalDate.Text = installationDate;
            lblExpirationDate.Text = expirationDate;
            lblMaintenance.Text = maintenancePlane;
            lblName.Text = clientName;
            lblSurname.Text = clientSurname;
            lblNameSig.Text = clientName;
            lblSurnamesig.Text = clientSurname;
            lblAddress.Text = clientAddress;
            CalcMonthlyPrice(MonthlyContractPrice, MonthlyServicePrice);
            int totalPrice = int.Parse(lblTotalPrice.Text);
            CalcCancellationFee(totalPrice, term);
            GetDisplayTechStaff();
        }

        private void CalcMonthlyPrice(string contractPrice, string servicePrice)
        {
            double monthlyprice = double.Parse(contractPrice) + double.Parse(servicePrice);

            lblTotalPrice.Text = monthlyprice.ToString();

            
        }
        private void CalcCancellationFee(int totalPrice, string term)
        {
          
            char termChar = term[0];
            int termAmount = termChar - '0';

            double cancelFee = (12 * termAmount) * totalPrice;

            lblCancelPrice.Text = Convert.ToString(cancelFee);
        }

        private void ContractRapportForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.Black, 3),
                         this.DisplayRectangle);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //Gather all necessary values

              string contactUID = lblUID.Text;
              string type = lblContractType.Text;
              string term = lblTerm.Text;
              string products = lblProducts.Text;
              string serviceName = lblService.Text;
              string installationDate = lblinstalDate.Text;
              string expirationDate  = lblExpirationDate.Text;
              string maintenancePlane = lblMaintenance.Text;
              string clientName = lblName.Text;
              string clientSurname = lblSurnamesig.Text;
              string clientAddress = lblAddress.Text;
            int totalCost = int.Parse(lblTotalPrice.Text);
            int cancellationFee = int.Parse(lblCancelPrice.Text);
            string address = lblAddress.Text;

            Contract cr = new Contract();


            //Set the appointment for technical stafff
           
            TechnicalStaff ts = new TechnicalStaff();
            List<TechnicalStaff> techStaffData = ts.GetBLTechnical();
            int count = 0;
            int index = -1;

            foreach (TechnicalStaff item in techStaffData)
            {
                string deployed = item.Deployed.ToString();


                if (deployed[0] == 'N')
                {
                    index = count;

                }
                else
                {
                    count++;
                }
            }
            int technicalID = techStaffData[index].TechnicalID;
            string techName = techStaffData[index].Name;
            string techSurnam = techStaffData[index].Surname;
            string techSpec = techStaffData[index].Specialization;
            string techDeployed = "YES";
            string techStaff = installationDate;

            ts.UpdateBLTechnical(technicalID, techName, techSurnam, techSpec, techDeployed, techStaff);

            //Set the client contract to active and expiration date

            Client cl = new Client();
            List<Client> clientData = cl.GetCustomer();
            int countClient = 0;
            int indexClient = -1;

            foreach (Client itemclient in clientData)
            {


                string obetainedclientUID = itemclient.ClientID;

                if (obetainedclientUID == ClientUID)
                {
                    indexClient = countClient;

                    
                }
                else
                {
                    countClient++;
                }
            }


            string Contact = clientData[indexClient].Contact;
            string email = clientData[indexClient].Email;
            string clientActiveContract = "YES";
            string clientExpiration = expirationDate;

            

            cl.UpdateBLCustomer(ClientUID, clientName, clientSurname, address,Contact,email,clientActiveContract,clientExpiration );

            //Store contract values n the database

            cr.InsertBLContract(contactUID, type, term, products, serviceName, installationDate, expirationDate, maintenancePlane, totalCost, cancellationFee, clientName, clientSurname, address);


            this.Close();
        }


        //Display the technical Staff Name
        private void GetDisplayTechStaff()
        {
            TechnicalStaff ts = new TechnicalStaff();
            List<TechnicalStaff> techStaffData = ts.GetBLTechnical();
            int count = 0;
            int index = -1;

            foreach (TechnicalStaff item in techStaffData)
            {
                string deployed = item.Deployed.ToString();


                if (deployed[0] == 'N')
                {
                    index = count;
                }
                else
                {
                    count++;
                }
            }     
            string techName = techStaffData[index].Name;
            string techSurnam = techStaffData[index].Surname;
      
            lblTechnicianName.Text = techName + " " + techSurnam;   
        }
    }
}
