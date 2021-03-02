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
    public class TechnicalStaff
    {
        private int technicalID;
        private string name;
        private string surname;
        private string specialization;
        private string deployed;
        private string deploymentDate;

        public TechnicalStaff()
        {
                
        }

        public TechnicalStaff(int technicalID, string name, string surname, string specialization, string deployed, string deploymentDate)
        {
            this.technicalID = technicalID;
            this.name = name;
            this.surname = surname;
            this.specialization = specialization;
            this.deployed = deployed;
            this.deploymentDate = deploymentDate;
        }

        public int TechnicalID { get => technicalID; set => technicalID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Specialization { get => specialization; set => specialization = value; }
        public string Deployed { get => deployed; set => deployed = value; }
        public string DeploymentDate { get => deploymentDate; set => deploymentDate = value; }

        public List<TechnicalStaff> GetBLTechnical()
        {
            EmployeeDatahandler ed = new EmployeeDatahandler();
            List<TechnicalStaff> ReadTechnical = new List<TechnicalStaff>();
            DataSet GetDataTechnical = ed.GetTechnical("tblTechnicalStaff");
            foreach (DataRow item in GetDataTechnical.Tables["tblTechnicalStaff"].Rows)
            {
                ReadTechnical.Add(new TechnicalStaff(
                    int.Parse(item["TechnicalID"].ToString()),
                    item["Name"].ToString(),
                    item["Surname"].ToString(),
                    item["Specialization"].ToString(),
                    item["Doployed"].ToString(),
                    item["DeployementDate"].ToString()));
               
            }
            return ReadTechnical;
        }

        public void InsertTechnical(string name, string surname, string specialization)
        {
            EmployeeDatahandler epd = new EmployeeDatahandler();
            epd.InsertTechnical(name, surname, specialization);
        }

        public void UpdateBLTechnical(int id, string name, string surname, string specialization, string deployed, string deploymentDate)
        {
            EmployeeDatahandler epd = new EmployeeDatahandler();
            epd.UpdateTechnical(id, name, surname, specialization, deployed, deploymentDate);
        }
        public void DeleteBLEmployee(int id)
        {
            EmployeeDatahandler epd = new EmployeeDatahandler();
           epd.DeleteTechnical(id);
        }
    }
}
