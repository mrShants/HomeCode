using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;
using System.Configuration;
namespace BusinessLogicLayer
{
    public class Employee
    {
       

        private int employeeID;
        private string name;
        private string surname;
        private string email;
        private string contact;
        private string position;
        private string salary;

       

        public Employee()
        {
                
        }
      
        

        public Employee(int employeeID, string name, string surname, string email, string contact, string position, string salary)
        {
            this.employeeID = employeeID;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.contact = contact;
            this.position = position;
            this.salary = salary;
        }

       

        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Email { get => email; set => email = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Position { get => position; set => position = value; }
        public string Salary { get => salary; set => salary = value; }

 

        public List<Employee> GetEmployee()
        {
            EmployeeDatahandler ed = new EmployeeDatahandler();
            List<Employee> ReadEmployee = new List<Employee>();
            DataSet GetDataEmployee = ed.GetEmployee("tblEmployees");
            foreach(DataRow item in GetDataEmployee.Tables["tblEmployees"].Rows)
            {
                ReadEmployee.Add(new Employee(
                    int.Parse(item["EmployeeID"].ToString()),
                    item["Name"].ToString(),
                    item["Surname"].ToString(),
                    item["Email"].ToString(),
                    item["Contact"].ToString(),
                    item["Position"].ToString(),
                    item["Salary"].ToString()));
            }
            return ReadEmployee;
        }


        public void InsertBLEmployee(string name, string surname, string email, string contact, string position, string salary)
        {
             EmployeeDatahandler epd = new EmployeeDatahandler();
            epd.InsertEmployee(name,  surname,  email,  contact,  position,  salary);
        }

        public void UpdateBLEmployee(int id , string name, string surname, string email, int contact, string position, double salary)
        {
            EmployeeDatahandler epd = new EmployeeDatahandler();
            epd.UpdateEmployee(id,name, surname, email, contact, position, salary);
        }

        public void DeleteBLEmployee(int id)
        {
            EmployeeDatahandler epd = new EmployeeDatahandler();
            epd.DeleteEmployee(id);
        }
    }
}
