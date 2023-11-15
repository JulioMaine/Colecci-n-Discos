using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace negocio
{
    public class Helper
    {
        public static bool soloNumeros(string cadena)
        {
            foreach (char item in cadena)
            {
                if (!(char.IsNumber(item)))
                    if (!(item.ToString() == ",")) // Para que me acepte numeros con decimales.                                                     
                        return false;
            }
            return true;
        }
    }
}
