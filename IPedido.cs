public interface IPedido
{
    int Id { get; }
    Cliente Cliente { get; }
    List<ItemPedido> Itens { get; }
    DateTime Data { get; }
    decimal ValorTotal { get; }
}
