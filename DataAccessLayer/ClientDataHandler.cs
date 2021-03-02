using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer

{
    public class ClientDataHandler

    {
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();
        string Query = null;

        public ClientDataHandler()
        {
            connection.DataSource = @"LAPTOP-CV1J30CG\sqlexpress";
            connection.InitialCatalog = "SmartHomeSystems";
            connection.IntegratedSecurity = true;
        }
        string connectionstring = @"Data Source=LAPTOP-CV1J30CG\sqlexpress;Initial Catalog=SmartHomeSystems;Integrated Security=True";
        public DataSet GetCustomer(string tableName)
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

        public void InsertClient(string clientUID, string name, string surname, string address, string contact, string email, string ActiveContract)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            using (conn)
            {
                try
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO tblClient(ClientID, Name, Surname, Address, Contact, Email,ActiveContract) VALUES ('" + clientUID + "','" + name + "','" + surname + "','" + address + "','" + contact + "','" + email+ "','" +ActiveContract+ "')", conn);
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

        public void UpdateClient(string id, string name, string surname, string address, string contact, string email, string activeContract, DateTime ContractExp)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            using (conn)
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("UPDATE tblClient SET Name = '" + name + "',Surname = '" + surname + "',Address = '" + address + "', Contact = '" + contact + "',Email= '" + email + "',ActiveContract='"+activeContract+"',ContractExpiration='"+ ContractExp+ "' WHERE ClientID = '" + id+ "'", conn);
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

        public void UpdateNormalClient(string id, string name, string surname, string address, string contact, string email)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            using (conn)
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("UPDATE tblClient SET Name = '" + name + "',Surname = '" + surname + "',Address = '" + address + "', Contact = '" + contact + "',Email= '" + email  + "' WHERE ClientID = '" + id + "'", conn);
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

        public void DeleteClient(string ClientID)
        {
            SqlConnection conn = new SqlConnection(connectionstring);
            using (conn)
            {
                try
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM tblClient WHERE ClientID = '" + ClientID + "'", conn);
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
