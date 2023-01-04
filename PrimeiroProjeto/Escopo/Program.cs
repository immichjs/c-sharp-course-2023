using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o preço: ");
            double price = double.Parse(Console.ReadLine());

            double discount = 0.0;

            if ( price > 100.0)
                discount = price * 0.1;
            
            Console.WriteLine(discount);
        }
    }
}