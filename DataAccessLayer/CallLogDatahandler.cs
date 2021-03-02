using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class CallLogDatahandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;

        public CallLogDatahandler()
        {
            connection.DataSource = @"LAPTOP-CV1J30CG\sqlexpress";
            connection.InitialCatalog = "SmartHomeSystems";
            connection.IntegratedSecurity = true;
        }
        string connectionstring = @"Data Source=LAPTOP-CV1J30CG\sqlexpress;Initial Catalog=SmartHomeSystems;Integrated Security=True";
        public DataSet GetCall(string tableName)
        {
            DataSet customerData = new DataSet();
            Query = string.Format("SELECT * FROM " + tableName);
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                adapter.FillSchema(customerData, SchemaType.Source, tableName);
                adapter.Fill(customerData, tableName);
                conn.Close();
            }
            return customerData;
        }

        public void InsertCall(string customerName, string customerSurname, string callDuration)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            using (conn)
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO tblCallLog(CustomerName, CustomerSurname, CallDuration) VALUES ('" + customerName + "','" + customerSurname + "','" + callDuration + "')", conn);
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
