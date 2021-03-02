using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer

{
    public class Client
    {
        private string clientID;
        private string name;
        private string surname;
        private string address;
        private string contact;
        private string email;
        private string activeContract;
        private string contractExpiration;

        public Client()
        {

        }

        public Client(string clientID, string name, string surname, string address, string contact, string email, string activeContract, string contractExpiration)
        {
            this.clientID = clientID;
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.contact = contact;
            this.email = email;
            this.activeContract = activeContract;
            this.contractExpiration = contractExpiration;
        }

        public string ClientID { get => clientID; set => clientID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Address { get => address; set => address = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Email { get => email; set => email = value; }
        public string ActiveContract { get => activeContract; set => activeContract = value; }
        public string ContractExpiration { get => contractExpiration; set => contractExpiration = value; }

        public List<Client> GetCustomer()
        {
            EmployeeDatahandler ed = new EmployeeDatahandler();
            List<Client> ReadCustomer = new List<Client>();
            DataSet GetDataEmployee = ed.GetEmployee("tblClient");
            foreach (DataRow item in GetDataEmployee.Tables["tblClient"].Rows)
            {
                ReadCustomer.Add(new Client(
                    item["ClientID"].ToString(),
                    item["Name"].ToString(),
                    item["Surname"].ToString(),
                    item["Address"].ToString(),
                    item["Contact"].ToString(),
                    item["Email"].ToString(),
                    item["ActiveContract"].ToString(),
                    item["ContractExpiration"].ToString()));
            }
            return ReadCustomer;

        }

            public void InsertBLCustomer(string clientUID, string name, string surname, string address, string contact, string email, string activeContract)
            {
                ClientDataHandler epd = new ClientDataHandler();
                epd.InsertClient(clientUID,name, surname, address, contact, email, activeContract);
            }
            public void UpdateBLCustomer(string id,string name, string surname, string address, string contact, string email, string activeContract, string contractExpiration)
            {
                ClientDataHandler epd = new ClientDataHandler();
                epd.UpdateClient(id, name, surname, address, contact, email, activeContract, DateTime.Parse(contractExpiration));
            }
            public void UpdateBLOCustomer(string id, string name, string surname, string address, string contact, string email)
            {
            ClientDataHandler epd = new ClientDataHandler();
            epd.UpdateNormalClient(id, name, surname, address, contact, email);
            }
        public void DeleteBLCustomer(string id)
        {
            ClientDataHandler epd = new ClientDataHandler();
            epd.DeleteClient(id);
        }

    }
}
