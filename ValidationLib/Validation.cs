using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationLib
{
    public class Validation
    {
        public static decimal DecimalValidation(string line)
        {
            decimal result;

            if (!decimal.TryParse(line, out result))
                return int.MinValue;
            else
                return result;
        }
        public static int IntValidation(string line)
        {
            int result;

            if (!int.TryParse(line, out result))
                return int.MinValue;
            else
                return result;
        }

        public static DateTime DateTimeValidation(string line)
        {
            DateTime dtOut;

            while (!DateTime.TryParseExact(line, "dd.MM.yyyy", null, DateTimeStyles.None, out dtOut))
            {
                return DateTime.MinValue;
            }

            return dtOut;
        }
    }
}
