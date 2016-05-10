using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    static public class Validation
    {

        static public bool String(string validate)
        {
            if (string.IsNullOrEmpty(validate) == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        static public bool Int(int validate)
        {

            int pInt = int.Parse(validate.ToString());

            if (pInt < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static public bool Double(double validate)
        {
            double pDub = double.Parse(validate.ToString());

            if (pDub < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
