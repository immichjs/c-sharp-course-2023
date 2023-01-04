using System;
using System.Globalization;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string cor1, cor2, cor3;
            string[] listColor;
            int age;
            char genre;
            double height;
            string[] person;

            Console.Write("Digite seu nome: ");
            name = Console.ReadLine();

            Console.Write("Digite as cores: ");
            listColor = Console.ReadLine().Split(' ');

            Console.Write("Digite sua idade: ");
            age = int.Parse(Console.ReadLine());

            Console.Write("Digite seu gênero [M/F]: ");
            genre = char.Parse(Console.ReadLine());

            Console.Write("Digite sua altura: ");
            height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Digite seu nome, idade, gênero e altura: ");
            person = Console.ReadLine().ToString(CultureInfo.InvariantCulture).Split(' ');

            cor1 = listColor[0];
            cor2 = listColor[1];
            cor3 = listColor[2];

            name = person[0];
            age = int.Parse(person[1]);
            genre = char.Parse(person[2]);
            height = double.Parse(person[3]);

            Console.WriteLine("Nome: " + name.ToUpper());
            Console.WriteLine("Idade: " + age);
            Console.WriteLine("Gênero: " + genre);
            Console.WriteLine("Altura: " + height);
            Console.WriteLine($"{cor1} - {cor2} - {cor3}");
            Console.WriteLine($"{name}, {age}, {genre}, {height:f2}");
        }
    }
}