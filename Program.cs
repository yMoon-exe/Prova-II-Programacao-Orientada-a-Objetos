var cliente = new Cliente(1, "Ana", "ana@mail.com", "12345678900");
var produto = new Produto(1, "Smartphone", 2500m, "Eletrônicos");
var item = new ItemPedido { Produto = produto, Quantidade = 1 };

var factory = new PedidoFactory();
var pedido = factory.CriarPedido(1, cliente, new List<ItemPedido> { item });

IDescontoStrategy desconto = new DescontoPorCategoriaStrategy();
Console.WriteLine($"Total: {pedido.ValorTotal:C} | Desconto: {desconto.CalcularDesconto(pedido):C}");
