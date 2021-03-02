using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class ProductConfigurationHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;

        public ProductConfigurationHandler()
        {
            connection.DataSource = @"LAPTOP-CV1J30CG\sqlexpress";
            connection.InitialCatalog = "SmartHomeSystems";
            connection.IntegratedSecurity = true;
        }


        string connectionstring = @"Data Source=LAPTOP-CV1J30CG\sqlexpress;Initial Catalog=SmartHomeSystems;Integrated Security=True";

        public DataSet GetProduct(string tableName)
        {
            DataSet ProductData = new DataSet();
            Query = string.Format("SELECT * FROM " + tableName);

            SqlConnection conn = new SqlConnection(connectionstring);

            using (conn)
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                adapter.FillSchema(ProductData, SchemaType.Source, tableName);
                adapter.Fill(ProductData, tableName);
                conn.Close();
            }
            return ProductData;
        }

        public void InsertProduct(string productUID,string name, string description, int yearModel, double price)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            using (conn)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tblProducts(ProductID , Name, Description, YearModel, Price) VALUES ('" + productUID + "','" + name + "','" + description + "','" + yearModel + "','" + price + "')", conn);
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

        public void UpdateProduct(string productID, string name, string description, int yearModel, double price)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            using (conn)
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("UPDATE tblProducts SET Name = '" + name + "',Description = '" + description + "',YearModel = '" + yearModel + "', Price = '" + price + "' WHERE ProductID = '" +productID+"'"  , conn);
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

        public void DeleteProduct(string productID)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            using (conn)
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM tblProducts WHERE ProductID = '"+productID+"'", conn);
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

        public DataSet GetConfiguration(string tableName)
        {
            DataSet ProductData = new DataSet();
            Query = string.Format("SELECT * FROM " + tableName);

            SqlConnection conn = new SqlConnection(connectionstring);

            using (conn)
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                adapter.FillSchema(ProductData, SchemaType.Source, tableName);
                adapter.Fill(ProductData, tableName);
                conn.Close();
            }
            return ProductData;
        }


    }
}
