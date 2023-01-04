using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o horário: ");
            int hour = int.Parse(Console.ReadLine());

            if (hour < 12)
            {
                Console.WriteLine("Bom dia");
            } else if (hour < 18)
            {
                Console.WriteLine("Boa tarde");
            } else if (hour < 24)
            {
                Console.WriteLine("Boa noite");
            } else if (hour > 0 && hour < 6)
            {
                Console.WriteLine("Boa madrugada");
            }

            Console.Write("Digite um número: ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} é par");
            } else
            {
                Console.WriteLine($"{number} é impar");
            }

            Console.Write("Digite sua idade: ");
            int age = int.Parse(Console.ReadLine());

            string auth = age >= 18 ? "Autorizado" : "Não autorizado";

            Console.WriteLine(auth);
        }
    }
}