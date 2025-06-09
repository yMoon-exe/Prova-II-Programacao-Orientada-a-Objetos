using System;
using System.Collections.Generic;
using LojaVirtual;

namespace LojaVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            var produto = new Produto(1, "Smartphone", 2500m, "Eletrônicos");
            var cliente = new Cliente(1, "Ana", "ana@mail.com", "12345678900");

            var item = new ItemPedido { Produto = produto, Quantidade = 1 };

            IPedidoFactory factory = new PedidoFactory();
            var pedido = factory.CriarPedido(1, cliente, new List<ItemPedido> { item });

            IDescontoStrategy desconto = new DescontoPorCategoriaStrategy();

            Console.WriteLine($"Total: {pedido.ValorTotal:C} | Desconto: {desconto.CalcularDesconto(pedido):C}");
        }
    }
}
