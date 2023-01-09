using System;

namespace Pessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa firstPerson, secondPerson;
            firstPerson = new Pessoa();
            secondPerson = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            firstPerson.name = Console.ReadLine();
            firstPerson.age = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            secondPerson.name = Console.ReadLine();
            secondPerson.age = int.Parse(Console.ReadLine());

            if (firstPerson.age > secondPerson.age)
            {
                Console.WriteLine($"Pessoa mais velha: {firstPerson.name}");
            } else
            {
                Console.WriteLine($"Pessoa mais velha: {secondPerson.name}");
            }
        }
    }
}