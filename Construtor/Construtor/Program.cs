namespace Construtor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Entre com os dados do produto: ");
			string name = Console.ReadLine() ?? "";
			double price = double.Parse(Console.ReadLine() ?? "");
			int quantity = int.Parse(Console.ReadLine() ?? "");

			Produto produto = new Produto(name, price, quantity);

			Console.WriteLine($"Dados do produto: {produto}");

			Console.WriteLine("Digite o numero de produtos a ser adicionado ao estoque: ");
			int addProduct = int.Parse(Console.ReadLine() ?? "");
			produto.AdicionarProdutos(addProduct);

			Console.WriteLine($"Dados atualizados: {produto}");

			Console.WriteLine("Digite o numero de produtos a ser removido do estoque: ");
			int removeProduct = int.Parse(Console.ReadLine() ?? "");
			produto.RemoverProdutos(removeProduct);

			Console.WriteLine($"Dados atualizados: {produto}");
		}
	}
}