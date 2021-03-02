using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
   public class Validator
    {
        
     public bool VailidateString (string input)
        {
            bool valid = true;

            if (input == null || input =="")
            {
                valid = false;
            }

            return valid;
        }

    
    }
}
