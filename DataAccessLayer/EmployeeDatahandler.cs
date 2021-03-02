using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class EmployeeDatahandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;

        public EmployeeDatahandler()
        {
            connection.DataSource = @"LAPTOP-CV1J30CG\sqlexpress";
            connection.InitialCatalog = "SmartHomeSystems";
            connection.IntegratedSecurity = true;
        }

        string connectionstring = @"Data Source=LAPTOP-CV1J30CG\sqlexpress;Initial Catalog=SmartHomeSystems;Integrated Security=True";


        public DataSet GetEmployee(string tableName)
        {
            DataSet employeeData = new DataSet();
            Query = string.Format("SELECT * FROM " + tableName);
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                adapter.FillSchema(employeeData, SchemaType.Source, tableName);
                adapter.Fill(employeeData, tableName);
                conn.Close();
            }
            return employeeData;
        }

        

        public void InsertEmployee(string name, string surname, string email, string contact, string position, string salary)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            using (conn)
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO tblEmployees(Name, Surname, Email, Contact, Position, Salary) VALUES ('" + name + "','" + surname + "','" + email + "','" + int.Parse(contact) + "','" + position + "','" + double.Parse(salary) + "')", conn);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.InsertCommand = cmd;
                    sda.InsertCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }

            }

               
                       
        }
    

    public void UpdateEmployee(int employeeID, string name, string surname, string email, int contact, string position, double salary)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            using (conn)
            {
                try
                {               
                    conn.Open();
                    SqlCommand command = new SqlCommand("UPDATE tblEmployees SET Name = '" + name + "',Surname = '" + surname + "',Email = '" + email + "', Contact = '" + contact + "',Position= '" + position + "',Salary= '" + salary + "' WHERE EmployeeID = " + employeeID, conn);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.UpdateCommand = command;
                    sda.UpdateCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

       

        public void DeleteEmployee(int EmployeeID)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            using (conn)
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM tblEmployees WHERE EmployeeID = "+EmployeeID,conn);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.DeleteCommand = command;
                    sda.DeleteCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
        public DataSet GetTechnical(string tableName)
        {
            DataSet technicalData = new DataSet();
            Query = string.Format("SELECT * FROM " + tableName);
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                adapter.FillSchema(technicalData, SchemaType.Source, tableName);
                adapter.Fill(technicalData, tableName);
                conn.Close();
            }
            return technicalData;
        }
        public void InsertTechnical(string name, string surname, string specialization)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            using (conn)
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO tblTechnicalStaff(Name, Surname, Specialization, Doployed, DeployementDate) VALUES ('" + name + "','" + surname + "','" + specialization + "','" + "NO" + "','" + null + "')", conn);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.InsertCommand = cmd;
                    sda.InsertCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }

            }



        }
        public void UpdateTechnical(int id, string name, string surname, string specialization, string deployed, string deploymentDate)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            using (conn)
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("UPDATE tblTechnicalStaff SET Name = '" + name + "',Surname = '" + surname + "',Specialization = '" + specialization + "', Doployed = '" + deployed + "',DeployementDate= '" + DateTime.Parse(deploymentDate) + "' WHERE TechnicalID = " + id, conn);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.UpdateCommand = command;
                    sda.UpdateCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
        public void DeleteTechnical(int id)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            using (conn)
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM tblTechnicalStaff WHERE TechnicalID = " + id, conn);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.DeleteCommand = command;
                    sda.DeleteCommand.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }
    }
}
