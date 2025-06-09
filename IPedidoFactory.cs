using LojaVirtual;

namespace LojaVirtual
{
    public interface IPedidoFactory
{
    Pedido CriarPedido(int id, Cliente cliente, List<ItemPedido> itens);
}
}
