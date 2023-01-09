using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proletario
{
    class Proletario
    {
        public string name;
        public double salary;
        public double tax;


        public double SalarioLiquido()
        {
            return salary - tax;
        }

        public void AumentarSalario(double percentage)
        {
            salary += salary * (percentage / 100);
        }

        public override string ToString()
        {
            return $"{name}, $ {SalarioLiquido().ToString("F2")}";
        }
    }
}
