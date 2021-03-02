using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class ContractType
    {
        private int contractID;
        private string contractName;
        private double monthlyPrice;
        private string contractTerm;
        private string products;
        private string representedChar;

        public ContractType()
        {

        }

        public ContractType(int contractID, string contractName, double monthlyPrice, string contractTerm, string products, string representedChar)
        {
            this.contractID = contractID;
            this.contractName = contractName;
            this.monthlyPrice = monthlyPrice;
            this.contractTerm = contractTerm;
            this.products = products;
            this.representedChar = representedChar;
        }

        public int ContractID { get => contractID; set => contractID = value; }
        public string ContractName { get => contractName; set => contractName = value; }
        public double MonthlyPrice { get => monthlyPrice; set => monthlyPrice = value; }
        public string ContractTerm { get => contractTerm; set => contractTerm = value; }
        public string Products { get => products; set => products = value; }
        public string RepresentedChar { get => representedChar; set => representedChar = value; }

        public List<ContractType> GetBLContractType()
        {
            ContractTypeDatahandler ctd = new ContractTypeDatahandler();
            DataSet GetContractTypeData = new DataSet();
            List<ContractType> ContractTypeData = new List<ContractType>();
            GetContractTypeData = ctd.GetContractType("tblContractType");

            foreach (DataRow item in GetContractTypeData.Tables["tblContractType"].Rows)
            {
                ContractTypeData.Add(new ContractType(
                    int.Parse(item["ContractID"].ToString()),
                    item["ContractName"].ToString(),
                    double.Parse(item["MonthlyPrice"].ToString()),
                    item["ContractTerm"].ToString(),
                    item["Products"].ToString(),
                    item["RepresentedChar"].ToString()));
            }

            return ContractTypeData;


        }

        public void InsertBLContractType(string name, int monthlyPrice, string contractTerm, string products, string representedChar )
        {
            ContractTypeDatahandler ctd = new ContractTypeDatahandler();
            ctd.InsertContractType(name, monthlyPrice, contractTerm, products, representedChar);
        }

    }


    
}
