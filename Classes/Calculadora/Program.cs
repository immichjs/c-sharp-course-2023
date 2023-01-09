namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine($"Circunferencia = {Calculadora.Circunferencia(raio):F2}");
            Console.WriteLine($"Volume = {Calculadora.Volume(raio)}");
            Console.WriteLine($"PI = {Math.PI:F2}");
        }
    }
}