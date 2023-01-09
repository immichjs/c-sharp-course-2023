using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluno
{
    class Aluno
    {
        public string name;
        public double nota1, nota2, nota3;

        public bool CalculaAprovado()
        {
            return CalculaNotaFinal() > 70.0 ? true : false;
        }

        public double CalculaNotaFinal()
        {
            double notaFinal = nota1 + nota2 + nota3;
            return notaFinal;
        }
    }
}
