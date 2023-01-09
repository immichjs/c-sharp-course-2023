using System;

namespace Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario: ");
            f1.name = Console.ReadLine();
            f1.salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Dados do segundo funcionario: ");
            f2.name = Console.ReadLine();
            f2.salary = double.Parse(Console.ReadLine());

            double salaryMed = (f1.salary + f2.salary) / 2;

            Console.WriteLine($"Salário médio = {salaryMed}");
        }
    }
}