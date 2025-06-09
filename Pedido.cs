
using LojaVirtual;

namespace LojaVirtual
{
    public class Pedido : IPedido
{
    public int Id { get; set; }
    public Cliente Cliente { get; set; }
    public List<ItemPedido> Itens { get; set; } = new List<ItemPedido>();
    public DateTime Data { get; set; } = DateTime.Now;

    public decimal ValorTotal => Itens.Sum(i => i.Subtotal);
}

}
