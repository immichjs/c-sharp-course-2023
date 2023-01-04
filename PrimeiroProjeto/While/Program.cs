using System;
using System.Globalization;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (number >= 0.0)
            {
                double sqrt = Math.Sqrt(number);
                Console.WriteLine(sqrt.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro número: ");
                number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número negativo.");
        }
    }
}