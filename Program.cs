using System;
using System.Collections.Generic;
using LojaVirtual;

namespace LojaVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            // Produtos
            var produtos = new List<Produto>
            {
                new Produto(1, "Notebook", 3500.00m, "Eletrônicos"),
                new Produto(2, "Mouse", 50.00m, "Acessórios"),
                new Produto(3, "Teclado Mecânico", 300.00m, "Acessórios"),
                new Produto(4, "Câmera Digital", 1500.00m, "Eletrônicos"),
                new Produto(5, "HD Externo", 450.00m, "Armazenamento"),
                new Produto(6, "Cadeira Gamer", 1200.00m, "Móveis"),
                new Produto(7, "Monitor", 800.00m, "Eletrônicos"),
                new Produto(8, "Pen Drive", 35.00m, "Armazenamento"),
                new Produto(9, "Celular", 2200.00m, "Eletrônicos"),
                new Produto(10, "Fone de Ouvido", 150.00m, "Acessórios")
            };

            // Clientes
            var clientes = new List<Cliente>
            {
                new Cliente(1, "João Silva", "joao@email.com", "12345678900"),
                new Cliente(2, "Maria Oliveira", "maria@email.com", "23456789001"),
                new Cliente(3, "Carlos Souza", "carlos@email.com", "34567890123"),
                new Cliente(4, "Ana Lima", "ana@email.com", "45678901234"),
                new Cliente(5, "Felipe Martins", "felipe@email.com", "56789012345")
            };

            // Fábrica de pedidos
            IPedidoFactory factory = new PedidoFactory();

            // Pedido 1
            var pedido1 = factory.CriarPedido(1, clientes[0], new List<ItemPedido>
            {
                new ItemPedido { Produto = produtos[0], Quantidade = 1 }, // Notebook
                new ItemPedido { Produto = produtos[1], Quantidade = 2 }  // Mouse
            });

            // Pedido 2
            var pedido2 = factory.CriarPedido(2, clientes[2], new List<ItemPedido>
            {
                new ItemPedido { Produto = produtos[3], Quantidade = 1 }, // Câmera Digital
                new ItemPedido { Produto = produtos[5], Quantidade = 1 }  // Cadeira Gamer
            });

            // Pedido 3
            var pedido3 = factory.CriarPedido(3, clientes[4], new List<ItemPedido>
            {
                new ItemPedido { Produto = produtos[6], Quantidade = 2 }, // Monitor
                new ItemPedido { Produto = produtos[9], Quantidade = 1 }  // Fone de Ouvido
            });

            // Estratégia de desconto
            IDescontoStrategy descontoStrategy = new DescontoPorCategoriaStrategy();

            // Lista de pedidos
            var pedidos = new List<Pedido> { pedido1, pedido2, pedido3 };

            foreach (var pedido in pedidos)
            {
                var desconto = descontoStrategy.CalcularDesconto(pedido);
                Console.WriteLine($"\nPedido #{pedido.Id}");
                Console.WriteLine($"Cliente: {pedido.Cliente.Nome}");
                Console.WriteLine($"Data: {pedido.Data}");

                Console.WriteLine("Itens:");
                foreach (var item in pedido.Itens)
                {
                    Console.WriteLine($"- {item.Produto.Nome} x{item.Quantidade} = R${item.Subtotal:F2}");
                }

                Console.WriteLine($"Subtotal: R${pedido.ValorTotal:F2}");
                Console.WriteLine($"Desconto: R${desconto:F2}");
                Console.WriteLine($"Total com Desconto: R${pedido.ValorTotal - desconto:F2}");
                Console.WriteLine("----------------------------------------------------");
            }
        }
    }
}
