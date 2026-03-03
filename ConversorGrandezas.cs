using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class ConversorGrandezas
    {
        public decimal converter(decimal valor, string tipoUnidade)
        {
            if (tipoUnidade == "Bilhões")
            {
                return valor / 1000000000m;
            }
            else if (tipoUnidade == "Trilhões")
            {
                return valor / 1000000000000m;
            }
            else if (tipoUnidade == "Milhões")
            {
                return valor / 1000000;
            }

            return valor;
        }
    }
}
