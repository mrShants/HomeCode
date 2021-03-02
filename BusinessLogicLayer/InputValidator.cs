using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace BusinessLogicLayer
{
    public class InputValidator
    {
        private string inputStr;

        public bool validate(string inputStr)
        {
           if (string.IsNullOrEmpty(inputStr))
            {
                return true;
            }
           else
            {
                return false;
            }
        }
        public bool validateYear(int inputYear)
        {
            if(inputYear > DateTime.Now.Year || inputYear < 1900)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool validateList(List<string> inputList)
        {
            bool valid = true;
            foreach ( string input in inputList)
            {
                if (string.IsNullOrEmpty(input))
                {
                     valid = true;
                }
                else
                {
                    valid = false;
                }
            }
            return valid;
           
            
        }
        public bool validateOrList(List<string> inputList)
        {
            bool valid = true;
            int count = inputList.Count();

            foreach (string input in inputList)
            {
                if (string.IsNullOrEmpty(input))
                {
                    count--;
                }
            }
            if (count <= 0)
            {
                valid = true;
            }
            else
            {
                valid = false;
            }


            return valid;
        }
         
    }
}
