using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    static class StringUtil
    {
        // acrescentar um this , no paramentro e assim criamos um metodo extra ou Extension Methods
        // é um metodo statico comum
        // porem um Extension Method NUNCA sobrescreve outro metodo.
        public static string Pluralize (this string palavra)
        {
            if (palavra.EndsWith("s"))
            {
                return palavra;
            }else
            {
                return palavra += "s";
            }
        }
    }
}
