using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BusinessLogicLayer
{
   public class UIDGenerator
    {

        public string GenerateProductUID(int serial, string manu, string year)
        {
            string productUID = String.Format("{0:0000}", serial) + manu + year;

            return productUID;
        }

        public string GenerateCustomerUID(int serial)
        {
            Random rng = new Random();
            string text = "ABCDE";
            int index = rng.Next(text.Length);

            string charIdentity = text[index].ToString();

           string customerUID = String.Format("{0:00000000}",serial)+charIdentity;

            return customerUID;
        }

        public string GenerateContractUID(string contractTypeRep, string serviceLevelRep, int serial , DateTime installationDate)
        {
            string year = DateTime.Now.Year.ToString();

            string contractUID = String.Format("{0:000000}", serial) + year + contractTypeRep[0].ToString() + serviceLevelRep[0].ToString();

            return contractUID;
        }
    }
}
