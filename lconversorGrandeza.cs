using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class IconversorGrandeza
    {
        public interface IconversorGrandeza
        {
            decimal converter(decimal valor);
            string obterSimbolo();
        }
    }
    public class converterBilhoes : IconversorGrandeza
    {
        public decimal converter(decimal valor) => valor / 1000000000m;
        public string obterSimbolo() => "Bi";
    }

    public class conversorTrilhoes : IconversorGrandeza
    {
        public decimal converter(decimal valor) => valor / 1000000000000;
        public string obterSimbolo() => "Tri";
    }
}
