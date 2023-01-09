using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Construtor
{
	class Produto
	{
		private string Name {
			get { return Name; }
			set { }
		}
		public double Price { get; private set; }
		public int Quantity { get; private set; }

		public Produto()
		{
			Name = "";
		}

		public Produto(string name, double price, int quantity)
		{
			Name = name;
			Price = price;
			this.AdicionarProdutos(quantity);
		}

		public Produto(string name, double price)
		{
			Name = name;
			Price = price;
		}
		
		public double ValorTotalEmEstoque()
		{
			return Price * Quantity;
		}

		public void AdicionarProdutos(int quantity)
		{
			Quantity += quantity;
		}

		public void RemoverProdutos(int quantity)
		{
			Quantity -= quantity;
		}

		public override string ToString()
		{
			return $"{Name}, $ {Price:f2}, {Quantity} unidades, total: $ {ValorTotalEmEstoque()}";
		}
	}
}