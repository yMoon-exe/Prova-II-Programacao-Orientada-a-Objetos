public class PedidoFactory : IPedidoFactory
{
    public Pedido CriarPedido(int id, Cliente cliente, List<ItemPedido> itens)
    {
        return new Pedido
        {
            Id = id,
            Cliente = cliente,
            Itens = itens,
            Data = DateTime.Now
        };
    }
}
