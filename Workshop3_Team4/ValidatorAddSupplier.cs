using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop3_Team4
{
    class ValidatorAddSupplier                                                     // Add supplier validator
    {    

        public static string LineEnd { get; set; } = "\n";

        public static string IsPresent(string value, string name)               // Validator to check if input data is entered (Supplier and SupplierID)
        {
            string msg = "";
            if (value == "")
            {
                msg += name + " is a required field." + LineEnd;
            }
            return msg;
        }

  
        // The IsInt32 and IsWithinRange methods were omitted from figure 12-15.     // Validator to check if data input for SupplierID is integer
        public static string IsInt32(string value, string name)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg += name + " must be a valid integer value." + LineEnd;
            }
            return msg;
        }

        public static string IsStringLgtNameOK(string value, string name)                // Validator to check if data input have less than the required maximum characters (Supplier)
        {

            string msg = "";
            if (value.Length > 50)
            {
                msg += "No more than 50 characters are allowed for " + name + "!" + LineEnd;
            }
            return msg;
        }

        public static string IsIntLgtNameOK(string value, string name)                // Validator to check if data input have less than the required maximum characters (SupplierID)
        {

            string msg = "";
            if (value.Length > 50)
            {
                msg += "No more than 10 characters are allowed for " + name + "!" + LineEnd;
            }
            return msg;
        }


       
        
    }
}
