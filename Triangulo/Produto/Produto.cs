using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produto
{
    class Produto
    {
        public string name;
        public double price;
        public int quantity;

        public double ValorTotalEmEstoque()
        {
            return price * quantity;
        }

        public void AdicionarProdutos(int quantity)
        {
            this.quantity += quantity;
        }

        public void RemoverProdutos(int quantity) { 
            this.quantity -= quantity;
        }

         public override string ToString()
        {
            return $"{name}, $ {price:f2}, {quantity} unidades, total: $ {ValorTotalEmEstoque()}";
        }
    }
}
