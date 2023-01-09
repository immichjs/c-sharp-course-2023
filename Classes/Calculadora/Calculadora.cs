using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculadora
    {
        public static double Circunferencia(double raio)
        {
            return Math.PI * 2 * raio;
        }

        public static double Volume(double raio)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(raio, 3);
        }
    }
}
