using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
	internal class ContaBancaria
	{
		public int Account { get; private set; }
		public string Owner { get; set; }
		public double Balance { get; private set; }

		public ContaBancaria()
		{
		}

		public ContaBancaria(int account, string owner)
		{
			Account = account;
			Owner = owner;
		}

		public ContaBancaria(int account, string owner, double balance) : this(account, owner)
		{
			Depositar(balance);
		}

		public void Depositar(double value)
		{
			Balance += value;
		}

		public void Sacar(double value)
		{
			Balance -= value;
		}

		public override string ToString()
		{
			return $"{Account}, Titular: {Owner}, Saldo: $ {Balance}";
		}
	}
}
