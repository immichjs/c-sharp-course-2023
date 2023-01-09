namespace Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            retangulo.width = double.Parse(Console.ReadLine());
            retangulo.height = double.Parse(Console.ReadLine());

            Console.WriteLine($"AREA = {retangulo.Area():F2}");
            Console.WriteLine($"PERÍMETRO = {retangulo.Perimetro():F2}");
            Console.WriteLine($"DIAGONAL = {retangulo.Diagonal():F2}");
        }
    }
}