using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public static class Helper
    {
        public static bool ValidarCampoNumero(string s)
        {
            if (int.TryParse(s, out _))
            {
                return true;
            }
            else return false;
        }

        public static bool ValidarCampoVacio(string s)
        {
            if (s == "" || s == null)
            {
                return false;
            }
            return true;
        }


    }
}
