using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class OrdersDataHandler
    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;

        public OrdersDataHandler()
        {
            connection.DataSource = @"LAPTOP-CV1J30CG\sqlexpress";
            connection.InitialCatalog = "SmartHomeSystems";
            connection.IntegratedSecurity = true;
        }

        string connectionstring = @"Data Source=LAPTOP-CV1J30CG\sqlexpress;Initial Catalog=SmartHomeSystems;Integrated Security=True";

        public DataTable GetOrders()
        {
            DataTable orderData = new DataTable();
            Query = string.Format("SELECT tblOrder.*,tblClient.* FROM tblOrder INNER JOIN tblClient ON tblOrder.ClientID=tblClient.ClientID ");
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                
                adapter.Fill(orderData);
                conn.Close();
            }
            return orderData;
        }
        public void InsertOrder(string product, string configuration,string clientID, DateTime orderDate, string installationDate, string orderPrice)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            using (conn)
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO tblOrder(Product, Configuration, ClientID, OrderDate, InstallationDate, OrderPrice) VALUES ('" + product + "','" + configuration + "','" + clientID + "','" + orderDate + "','" + DateTime.Parse(installationDate) + "','" + int.Parse(orderPrice) + "')", conn);
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

        public void UpdateOrder(int orderID, string client, string product, string configuration, DateTime orderDate, double totalPrice)
        {
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                try
                {

                    Query = string.Format("UPDATE tblEmployee SET Client = ''" + client + "',Product = ''" + product + "',Configuration = ''" + configuration + "', OrderDate = ''" + orderDate + "',TotalPrice= ''" + totalPrice);
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

        public void DeleteOrder(int orderID)
        {
            using (SqlConnection conn = new SqlConnection(connection.ToString()))
            {
                try
                {

                    Query = string.Format("DELETE FROM tblOrders WHERE OrderID = {0}", orderID);
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
