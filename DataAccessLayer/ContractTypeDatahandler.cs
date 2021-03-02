using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayer
{
    public class ContractTypeDatahandler
    {
        string Query = null;
        SqlConnectionStringBuilder connection = new SqlConnectionStringBuilder();

        public ContractTypeDatahandler()
        {
            connection.DataSource = @"LAPTOP-CV1J30CG\sqlexpress";
            connection.InitialCatalog = "SmartHomeSystems";
            connection.IntegratedSecurity = true;
        }

        string connectionString = @"Data Source=LAPTOP-CV1J30CG\sqlexpress;Initial Catalog=SmartHomeSystems;Integrated Security=True";

        public DataSet GetContractType(string tablename)
        {
            DataSet ContactData = new DataSet();
            Query = string.Format("SELECT * FROM " + tablename);

            SqlConnection conn = new SqlConnection(connectionString);

            using (conn)
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                sda.FillSchema(ContactData, SchemaType.Source, tablename);
                sda.Fill(ContactData, tablename);
                conn.Close();
            }

            return ContactData;
        }


        public void InsertContractType(string contractName, int monthlyPrice, string contractTerm, string products, string representedChar )
        {
            SqlConnection conn = new SqlConnection(connectionString);

            using (conn)
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tblContractType(ContractName, MonthlyPrice, ContractTerm, Products, RepresentedChar) VALUES ('" + contractName + "','" + monthlyPrice + "','" + contractTerm + "','" + products + "','" + representedChar + "')", conn);
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
