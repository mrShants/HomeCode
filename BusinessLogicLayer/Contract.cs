using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
   public class Contract
    {
        private string contractID;
        private string type;
        private string term;
        private string products;
        private string serviceName;
        private string installationDate;
        private string expirationDate;
        private string maintenancePlan;
        private string totalMonthlyPrice;
        private string cancellationPrice;
        private string clientName;
        private string clientSurname;
        private string address;

        public Contract()
        {

        }

        public Contract(string contractID, string type, string term, string products, string serviceName, string installationDate, string expirationDate, string maintenancePlan, string totalMonthlyPrice, string cancellationPrice, string clientName, string clientSurname, string address)
        {
            this.contractID = contractID;
            this.type = type;
            this.term = term;
            this.products = products;
            this.serviceName = serviceName;
            this.installationDate = installationDate;
            this.expirationDate = expirationDate;
            this.maintenancePlan = maintenancePlan;
            this.totalMonthlyPrice = totalMonthlyPrice;
            this.cancellationPrice = cancellationPrice;
            this.clientName = clientName;
            this.clientSurname = clientSurname;
            this.address = address;
        }

        public string ContractID { get => contractID; set => contractID = value; }
        public string Type { get => type; set => type = value; }
        public string Term { get => term; set => term = value; }
        public string Products { get => products; set => products = value; }
        public string ServiceName { get => serviceName; set => serviceName = value; }
        public string InstallationDate { get => installationDate; set => installationDate = value; }
        public string MaintenancePlan { get => maintenancePlan; set => maintenancePlan = value; }
        public string TotalMonthlyPrice { get => totalMonthlyPrice; set => totalMonthlyPrice = value; }
        public string CancellationPrice { get => cancellationPrice; set => cancellationPrice = value; }
        public string ClientName { get => clientName; set => clientName = value; }
        public string ClientSurname { get => clientSurname; set => clientSurname = value; }
        public string Address { get => address; set => address = value; }
        public string ExpirationDate { get => expirationDate; set => expirationDate = value; }

        public List<Contract> GetBLContract()
        {
            DataSet ContractData = new DataSet();
            List<Contract> getContractData = new List<Contract>();
            ContractDatahandler cd = new ContractDatahandler();
            ContractData = cd.GetContractData("tblContract");

            foreach (DataRow item in ContractData.Tables["tblContract"].Rows)
            {
                getContractData.Add(new Contract(
                    item["ContractID"].ToString(),
                    item["Type"].ToString(),
                    item["Term"].ToString(),
                    item["Products"].ToString(),
                    item["ServiceName"].ToString(),
                    item["InstallationDate"].ToString(),
                    item["ExpirationDate"].ToString(),
                    item["MaintenancePlan"].ToString(),
                    item["TotalMonthlyPrice"].ToString(),
                    item["CancellationPrice"].ToString(),
                    item["ClientName"].ToString(),
                    item["ClientSurname"].ToString(),
                    item["Address"].ToString()));
               
            }
            return getContractData;
          
        }

        public void InsertBLContract(string contractUID, string contractName, string term, string products, string serviceName, string installationDate, string expirationDate,
            string maintenanceDate, int totalMonthlyPrice, int cancellationPrice, string clientName, string clientSurname, string address)
        {
            ContractDatahandler cd = new ContractDatahandler();
            cd.InsertContract(contractUID, contractName, term, products, serviceName, installationDate, expirationDate, maintenanceDate, totalMonthlyPrice, cancellationPrice, clientName, clientSurname, address);
        }

        public void UpdateBLContract(string contractUID, string contractType, int totalMonthlyPrice)
        {
            ContractDatahandler cd = new ContractDatahandler();
            cd.UpdateContract(contractUID, contractType, totalMonthlyPrice);
        }



    }
}
