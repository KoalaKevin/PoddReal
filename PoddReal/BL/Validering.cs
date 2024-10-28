using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Validering
    {

        public static bool HarVarde<T>(T varde)
        {
            bool harVarde = false;

            if (varde != null)
            {
                harVarde = true;
            }

            return harVarde;
        }

        public static bool StrangHarVarde(string strang)
        {
            bool harVarde = true;

            if (string.IsNullOrWhiteSpace(strang))
            {
                harVarde = false;
            }

            return harVarde;
        }

        public static bool FinnsUrl(string url, List<Podd> lista)
        {
            return lista.Any(p => p.Url.Equals(url));
        }

        public static bool ArStrang(object varde)
        {
            return varde is string;
        }
    }
}
