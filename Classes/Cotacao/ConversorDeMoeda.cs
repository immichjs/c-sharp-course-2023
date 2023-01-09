using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cotacao
{
    class ConversorDeMoeda
    {
        public static double IOF = 0.06;
        public static double dolarCotacao;

        public static double CalculaValorPorDolares(double valor)
        {
            double reais = valor * dolarCotacao;

            return reais += reais * IOF;
        }
    }
}
