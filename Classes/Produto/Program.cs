namespace Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            produto.name = Console.ReadLine();
            produto.price = double.Parse(Console.ReadLine());
            produto.quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dados do produto: {produto}");

            Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque: ");
            int addProduct = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(addProduct);

            Console.WriteLine($"Dados atualizados: {produto}");

            Console.WriteLine("Digite o numero de produtos a ser removido do estoque: ");
            int removeProduct = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(removeProduct);

            Console.WriteLine($"Dados atualizados: {produto}");
        }
    }
}