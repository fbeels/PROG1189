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
            if (string.IsNullOrEmpty(validate))
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
            try
            {
                return int.Parse(validate);
            }
            catch (Exception)
            {

                throw new FormatException(validate + " is not a valid number. Please enter a proper value");
            }
        }

        static public double Double(string validate)
        {
            try
            {
                return double.Parse(validate);
            }
            catch (Exception)
            {

                throw new FormatException(validate + " is not a valid number. Please enter a proper value");
            }
        }


    }
}
