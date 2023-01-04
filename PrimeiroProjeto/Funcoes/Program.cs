using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digiete três números: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int result = Maior(a, b, c);

            Console.WriteLine($"Maior = {result}");
        }

        static int Maior (int a, int b, int c)
        {
            int maior;

            if (a > b && a > c)
            {
                maior = a;
            }
            else if (b > c)
            {
                maior = b;
            }
            else
            {
                maior = c;
            }

            return maior;
        }
    }
}