using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class UserDataHandler
    {


        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;

        public UserDataHandler()
        {
            connection.DataSource = "LAPTOP-CV1J30CG/sqlexpress";
            connection.InitialCatalog = "SmartHomeSystemDB";
            connection.IntegratedSecurity = true;
        }

        public DataSet GetClients(string tableName)
        {
            DataSet UserData = new DataSet();
            Query = string.Format("SELECT * FROM " + tableName);
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                adapter.FillSchema(UserData, SchemaType.Source, tableName);
                adapter.Fill(UserData, tableName);
                conn.Close();
            }
            return UserData;
        }
        public void InsertUser(string userName, string password)
        {
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                try
                {
                    Query = "INSERT INTO tblUsers(UserName, PassWord) VALUES (" + userName + "," + password + ")";
                    SqlCommand command = new SqlCommand(Query, conn);
                    command.ExecuteNonQuery();
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
