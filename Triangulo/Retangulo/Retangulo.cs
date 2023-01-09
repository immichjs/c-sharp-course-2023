using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retangulo
{
    class Retangulo
    {
        public double width;
        public double height;

        public double Area()
        {
            return width * height;
        }

        public double Perimetro()
        {
            return 2 * (width + height);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
        }
    }
}
