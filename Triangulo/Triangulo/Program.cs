using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            //double xA, xB, xC, yA, yB, yC;
            //double areaX, areaY;
            //string maior;

            //Console.WriteLine("Entre com as medidas do triangulo X:");
            //xA = double.Parse(Console.ReadLine());
            //xB = double.Parse(Console.ReadLine());
            //xC = double.Parse(Console.ReadLine());

            //Console.WriteLine("Entre com as medidas do triangulo Y:");
            //yA = double.Parse(Console.ReadLine());
            //yB = double.Parse(Console.ReadLine());
            //yC = double.Parse(Console.ReadLine());

            //double p = (xA + xB + xC) / 2;
            //areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            //p = (yA + yB + yC) / 2;
            //areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            //Console.WriteLine($"Área de X = {areaX}");
            //Console.WriteLine($"Área de Y = {areaY}");

            //maior = areaX > areaY ? "X" : "Y";
            //Console.WriteLine($"Maior área {maior}");

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triangulo X:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triangulo Y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine($"Área de X = {areaX}");
            Console.WriteLine($"Área de Y = {areaY}");

            if (areaX > areaY)
            {
                Console.WriteLine($"Maior área X");

            } else
            {
                Console.WriteLine($"Maior área Y");
            }
        }
    }
}