using LojaVirtual;

namespace LojaVirtual
{
    public class DescontoPorCategoriaStrategy : IDescontoStrategy
{
    public decimal CalcularDesconto(Pedido pedido)
    {
        return pedido.Itens.Any(i => i.Produto.Categoria == "Eletrônicos")
            ? pedido.ValorTotal * 0.10m : 0m;
    }
}
}

