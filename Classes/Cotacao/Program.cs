namespace Cotacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar? ");
            ConversorDeMoeda.dolarCotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dolares você vai comprar? ");
            double dolar = double.Parse(Console.ReadLine());

            Console.WriteLine($"Valor a ser pago em reais = $ {ConversorDeMoeda.CalculaValorPorDolares(dolar):F2}");
        }
    }
}