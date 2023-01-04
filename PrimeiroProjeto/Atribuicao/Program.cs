using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            string b = "ABC";
            Console.WriteLine(b);

            b += "DEF";
            Console.WriteLine(b);

            int c = 10;
            int d = c++;
            Console.WriteLine(c);
            Console.WriteLine(d);
        }
    }
}
