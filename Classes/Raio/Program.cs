namespace Raio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());

            Console.WriteLine($"Circunferencia = {Circunferencia(raio):F2}");
            Console.WriteLine($"Volume = {Volume(raio)}");
            Console.WriteLine($"PI = {Math.PI:F2}");
        }

        static double Circunferencia(double raio)
        {
            return Math.PI * 2 * raio;
        }

        static double Volume (double raio)
        {
            return 4.0 / 3.0 * Math.PI * Math.Pow(raio, 3);
        }
    }
}