using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class ServiceDatahandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;

        public ServiceDatahandler()
        {
            connection.DataSource = @"LAPTOP-CV1J30CG\sqlexpress";
            connection.InitialCatalog = "SmartHomeSystems";
            connection.IntegratedSecurity = true;
        }

        string connectionString = @"Data Source = LAPTOP-CV1J30CG\sqlexpress; Initial Catalog = SmartHomeSystems; Integrated Security = true";

        public DataSet GetService(string tableName)
        {
            DataSet ServiceData = new DataSet();
            Query = string.Format("SELECT * FROM " + tableName);

            SqlConnection conn = new SqlConnection(connectionString);

            using (conn)
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                adapter.FillSchema(ServiceData, SchemaType.Source, tableName);
                adapter.Fill(ServiceData, tableName);
                conn.Close();
            }
            return ServiceData;
        }

        public void InsertService(string serviceName, string maintanencePlan, double servicePrice, DateTime installationDate, string representedChar)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            using (conn)
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO tblService(ServiceName,MaintenancePlan,ServicePrice,InstallationDate,RepresentedChar) VALUES('" + serviceName + "','" + maintanencePlan + "','" + servicePrice + "','" + installationDate + "','" + representedChar + "')", conn);
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
    }
}
