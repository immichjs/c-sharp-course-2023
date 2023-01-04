using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números quer digitar?");
            int repeat = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 1; i <= repeat; i++)
            {
                Console.WriteLine($"Digite o valor #{i}");
                int x = int.Parse(Console.ReadLine());

                result += x;
            }

            Console.WriteLine($"Resultado = {result}");
        }
    }
}