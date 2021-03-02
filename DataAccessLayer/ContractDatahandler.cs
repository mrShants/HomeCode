using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
   public class ContractDatahandler
    {
        string Query = null;

        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();

        public ContractDatahandler()
        {
            connection.DataSource = @"LAPTOP-CV1J30CG\sqlexpress";
            connection.InitialCatalog = "SmartHomeSystems";
            connection.IntegratedSecurity = true;

        }

        string connectionString = @"Data Source=LAPTOP-CV1J30CG\sqlexpress;Initial Catalog=SmartHomeSystems;Integrated Security=True";


        public DataSet GetContractData(string tablename)
        {
            DataSet contractData = new DataSet();
            Query = string.Format("SELECT * FROM " + tablename);

            SqlConnection conn = new SqlConnection(connectionString);

            using (conn)
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                sda.FillSchema(contractData, SchemaType.Source, tablename);
                sda.Fill(contractData, tablename);
                conn.Close();
            }

            return contractData;
        }

        public void InsertContract(string contractID, string type, string term, string products, string serviceName, string installationDate,
            string expirationDate, string maintenancePlan, int totalMonthlyPrice,
            int cancellationPrice, string clientName, string clientSurname, string address )
        {
            SqlConnection conn = new SqlConnection(connectionString);

            using (conn)
            {


                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tblContract(ContractID, Type, Term, Products, ServiceName, InstallationDate, ExpirationDate, MaintenancePlan, TotalMonthlyPrice, CancellationPrice, ClientName, ClientSurname, Address) VALUES ('" + contractID + "','" + type + "','" + term + "','" + products + "','" + serviceName + "','" + DateTime.Parse(installationDate) + "','" + DateTime.Parse(expirationDate) + "','" + maintenancePlan + "','" + totalMonthlyPrice + "','" + cancellationPrice + "','" + clientName + "','" + clientSurname + "','" + address + "')", conn);
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

        public void UpdateContract(string contractID, string type, int totalMonthlyPrice)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            using (conn)
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("UPDATE tblContract SET Type = '" + type + "',TotalMonthlyPrice = '" + totalMonthlyPrice + "' WHERE ProductID = '" + contractID + "'", conn);
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.UpdateCommand = command;
                    sda.UpdateCommand.ExecuteNonQuery();



                }
                catch (SqlException)
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
