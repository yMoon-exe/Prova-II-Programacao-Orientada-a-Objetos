public class ItemPedido
{
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }

    public decimal Subtotal => Produto.Preco * Quantidade;
}
