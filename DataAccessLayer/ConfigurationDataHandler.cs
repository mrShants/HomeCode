using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ConfiguratonDataHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;

        public ConfiguratonDataHandler()
        {
            connection.DataSource = "LAPTOP-CV1J39CG/SQLEXPRESS";
            connection.InitialCatalog = "SmartHomeSystemDB";
            connection.IntegratedSecurity = true;
        }
        public DataSet GetConfiguration(string tableName)
        {
            DataSet configData = new DataSet();
            Query = string.Format("SELECT * FROM " + tableName);
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                adapter.FillSchema(configData, SchemaType.Source, tableName);
                adapter.Fill(configData, tableName);
                conn.Close();
            }
            return configData;
        }

        public void InsertConfiguration(int configID, string confType, string products, string confPrice)
        {
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                try
                {
                    Query = "INSERT INTO tblConfiguration(configID, ConfType, Products, ConfPrice) VALUES (" + configID + confType + "," + products + "," + confPrice + ")";
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

        public void UpdateConfiguration(int configID, string confType, string products, string confPrice)
        {
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                try
                {

                    Query = string.Format("UPDATE tblConfiguration SET ConfType = ''" + confType + "', Products = ''" + products + "',ConfPrice = ''" + confPrice + "', products =''" + products + "' WHERE ConfigurationID =''" + configID);
                    conn.Open();
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

        public void DeleteConfiguration(int configurationID)
        {
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                try
                {

                    Query = string.Format("DELETE FROM tblConfiguration WHERE ConfigurationID = {0}", configurationID);
                    conn.Open();
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
