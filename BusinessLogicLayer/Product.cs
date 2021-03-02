using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLogicLayer
{
     public class Product
    {
        private string productID;
        private string name;
        private string description;
        private int yearModel;
        private double price;

        public Product()
        {
                
        }
        public Product(string productID, string name, string description, int yearModel, double price)
        {
            this.productID = productID;
            this.name = name;
            this.description = description;
            this.yearModel = yearModel;
            this.price = price;
        }

        public string ProductID { get => productID; set => productID = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int YearModel { get => yearModel; set => yearModel = value; }
        public double Price { get => price; set => price = value; }


        public List<Product> GetBLProduct()
        {
            ProductConfigurationHandler PCH = new ProductConfigurationHandler();
            List<Product> ReadProduct = new List<Product>();
            DataSet GetDataProduct = PCH.GetProduct("tblProducts");
            foreach (DataRow item in GetDataProduct.Tables["tblProducts"].Rows)
            {
                ReadProduct.Add(new Product(
                    item["ProductID"].ToString(),
                    item["Name"].ToString(),
                    item["Description"].ToString(),
                    int.Parse(item["YearModel"].ToString()),
                    double.Parse(item["Price"].ToString())));
            }
            return ReadProduct;
        }

        public void InsertBLProduct(string productUID,string name, string description, string yearModel, string price)
        {
            ProductConfigurationHandler epd = new ProductConfigurationHandler();
            epd.InsertProduct(productUID,name, description, int.Parse(yearModel), double.Parse(price));
        }

        public void UpdateBLProduct(string id, string name, string description, string yearModel, string price)
        {
            ProductConfigurationHandler epd = new ProductConfigurationHandler();
            epd.UpdateProduct(id, name, description, int.Parse(yearModel), double.Parse(price));
        }

        public void DeleteBLProduct(string id)
        {
            ProductConfigurationHandler epd = new ProductConfigurationHandler();
            epd.DeleteProduct(id);
        }
    }
}
