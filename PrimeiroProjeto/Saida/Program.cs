using System;
using System.Globalization;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mich";
            short age = 21;
            char genre = 'M';
            double balance = 2330.46;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(genre);
            Console.WriteLine(balance);

            Console.WriteLine(balance.ToString("F2"));
            Console.WriteLine(balance.ToString("F4"));
            Console.WriteLine(balance.ToString("F4", CultureInfo.InvariantCulture));

            Console.WriteLine($"{name} tem {age} anos e tem saldo de R$ {balance:F2}");

            string product1 = "Computador";
            string product2 = "Mesa de escritório";

            age = 21;
            int code = 5290;
            genre = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double measure = 53.234567;

            Console.WriteLine();
            Console.WriteLine("Produtos:");
            Console.WriteLine($"{product1}, cujo preço é $ {price1:F2}");
            Console.WriteLine($"{product2}, cujo preço é $ {price2:F2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {age} anos de idade, código {code} e gênero: {genre}");
            Console.WriteLine();
            Console.WriteLine($"Medida com oito casas decimais: {measure:F8}");
            Console.WriteLine($"Arredondado (3 casas decimais): {measure:F3}");
            Console.WriteLine($"Separador decimal invariant culture: {measure.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
