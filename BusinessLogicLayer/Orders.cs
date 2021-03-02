using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using System.Windows;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLogicLayer
{
    public class Orders
    {
        private string product;
        private string configuration;
        private string orderDate;
        private string clientID;
        private string installationDate;
        private double orderPrice;

        public Orders()
        {

        }


        public Orders(string product, string configuration, string orderDate, string clientID, string installationDate, double orderPrice)
        {
            this.product = product;
            this.configuration = configuration;
            this.orderDate = orderDate;
            this.clientID = clientID;
            this.installationDate = installationDate;
            this.orderPrice = orderPrice;
        }

        public string Product { get => product; set => product = value; }
        public string Configuration { get => configuration; set => configuration = value; }
        public string OrderDate { get => orderDate; set => orderDate = value; }
        public string ClientID { get => clientID; set => clientID = value; }
        public string InstallationDate { get => installationDate; set => installationDate = value; }
        public double OrderPrice { get => orderPrice; set => orderPrice = value; }


        public void insertBLOrder(string product, string configuration, string clientID, DateTime orderDate, string installationDate, string orderPrice)
        {
            OrdersDataHandler odh = new OrdersDataHandler();
            odh.InsertOrder(product, configuration, clientID, orderDate,  installationDate, orderPrice);
        }
    }
}
