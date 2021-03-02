using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
using System.Data;
using System.Data.Sql;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class Configuration
    {

        private int configurationID;
        private string type;
        private string products;
        private double price;

        public Configuration()
        {
                
        }

        public Configuration(int configurationID, string type, string products, double price)
        {
            this.ConfigurationID = configurationID;
            this.Type = type;
            this.Products = products;
            this.Price = price;
        }

        public int ConfigurationID { get => configurationID; set => configurationID = value; }
        public string Type { get => type; set => type = value; }
        public string Products { get => products; set => products = value; }
        public double Price { get => price; set => price = value; }

        public List<Configuration> GetBLConfiguration()
        {
            ProductConfigurationHandler  ed = new ProductConfigurationHandler();
            List<Configuration> ReadConfiguration = new List<Configuration>();
            DataSet GetDataConfiguration = ed.GetConfiguration("tblConfiguration");
            foreach (DataRow item in GetDataConfiguration.Tables["tblConfiguration"].Rows)
            {
                ReadConfiguration.Add(new Configuration(
                    int.Parse(item["ConfigurationID"].ToString()),
                    item["Type"].ToString(),
                    item["Products"].ToString(),
                    double.Parse(item["Price"].ToString())));
            }
            return ReadConfiguration;
        }
    }
}
