using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Service
    {
        private int serviceID;
        private string serviceName;
        private string maintenancePlan;
        private double servicePrice;
        private string installationDate;
        private string representedChar;

        public Service(int serviceID, string serviceName, string maintenancePlan, double servicePrice, string installationDate, string representedChar)
        {
            this.serviceID = serviceID;
            this.serviceName = serviceName;
            this.maintenancePlan = maintenancePlan;
            this.servicePrice = servicePrice;
            this.installationDate = installationDate;
            this.representedChar = representedChar;
        }

        public Service()
        {

        }

        public int ServiceID { get => serviceID; set => serviceID = value; }
        public string ServiceName { get => serviceName; set => serviceName = value; }
        public string MaintenancePlan { get => maintenancePlan; set => maintenancePlan = value; }
        public double ServicePrice { get => servicePrice; set => servicePrice = value; }
        public string InstallationDate { get => installationDate; set => installationDate = value; }
        public string RepresentedChar { get => representedChar; set => representedChar = value; }

        public List<Service> GetBLService()
        {
            ServiceDatahandler SDH = new ServiceDatahandler();
            List<Service> ReadService = new List<Service>();
            DataSet GetDataService = SDH.GetService("tblService");
            foreach (DataRow item in GetDataService.Tables["tblService"].Rows)
            {
                ReadService.Add(new Service(
                    int.Parse(item["ServiceID"].ToString()),
                    item["ServiceName"].ToString(),
                    item["MaintenacePlan"].ToString(),
                    double.Parse(item["ServicePrice"].ToString()),
                    item["InstallationDate"].ToString(),
                    item["RepresentedChar"].ToString()));
            }
            return ReadService;
        }

        public void InsertBLService(string serviceName, string maintenancePlan, double price, DateTime date,string representedChar)
        {
            ServiceDatahandler sd = new ServiceDatahandler();
            sd.InsertService(serviceName, maintenancePlan, price, date, representedChar);
        }

    }
}
