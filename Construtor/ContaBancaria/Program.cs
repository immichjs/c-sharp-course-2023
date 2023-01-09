using System.Runtime.CompilerServices;

namespace ContaBancaria
{
	internal class Program
	{
		static void Main(string[] args)
		{
			ContaBancaria contaBancaria;
			double deposit, withdraw;

			Console.Write("Entre com o numero da conta: ");
			int account = int.Parse(Console.ReadLine());

			Console.Write("Entre com o titular da conta: ");
			string owner = Console.ReadLine();

			Console.Write("Haverá deposito inicial (s/n)? ");
			char initialDeposit = char.Parse(Console.ReadLine());

			if (initialDeposit == 's' || initialDeposit == 'S') {
				Console.Write("Entre com o valor de depósito inicial: ");
				deposit = double.Parse(Console.ReadLine());

				contaBancaria = new ContaBancaria(account, owner, deposit);
			} else
			{
				contaBancaria = new ContaBancaria(account, owner);
			}

			Console.WriteLine("Dados da conta:");
			Console.WriteLine($"Conta {contaBancaria}");

			Console.Write("Entre com valor de depósito: ");
			deposit = double.Parse(Console.ReadLine());
			contaBancaria.Depositar(deposit);

			Console.WriteLine("Dados da conta atualizados:");
			Console.WriteLine($"Conta {contaBancaria}");

			Console.Write("Entre com um valor para saque: ");
			withdraw = double.Parse(Console.ReadLine());
			contaBancaria.Sacar(withdraw);

			Console.WriteLine("Dados da conta atualizados:");
			Console.WriteLine($"Conta {contaBancaria}");
		}
	}
}