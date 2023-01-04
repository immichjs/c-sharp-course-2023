using System;

namespace FirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 100; // -128 to 127
            byte b = 255; // 0 to 255
            short c = 450; // -32768 to 32767
            int d = 2147483647;
            long e = 21474836478L;
            bool f = true;
            char g = 'A';
            float h = 4.5f;
            double i = 4.5;
            string name = "Mich";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;
            int min = int.MinValue;
            int max = int.MaxValue;
            double maxd = double.MaxValue;
            decimal maxdc = decimal.MaxValue;
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(name);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.WriteLine(maxd);
            Console.WriteLine(maxdc);
        }
    }
}