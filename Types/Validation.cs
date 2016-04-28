using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    static public class Validation
    {

        static public string String(string validate)
        {            
           if (string.IsNullOrEmpty(validate) == true)
            {
                throw new FormatException(validate + " is not a valid entry for this field. Please enter a proper value.");
            }
           else
            {
                return validate;
            }
        }



        static public int Int(string validate)
        {
            int ret;
            int.TryParse(validate, out ret);

            if (ret ==0)
            {
                throw new FormatException(validate + " is not a valid number. Please enter a proper value");
            }else
            {
                return ret;
            }             
        }

        static public double Double(string validate)
        {
            double ret;
            double.TryParse(validate,out ret);
            if (ret == 0)
            {
                throw new FormatException(validate + " is not a valid number. Please enter a proper value");               
            }else
            {
                return ret;
            }            
        }


    }
}
