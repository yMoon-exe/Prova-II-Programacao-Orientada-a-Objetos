public class DescontoPorQuantidadeStrategy : IDescontoStrategy
{
    public decimal CalcularDesconto(Pedido pedido)
    {
        int total = pedido.Itens.Sum(i => i.Quantidade);
        return total >= 10 ? pedido.ValorTotal * 0.07m : 0m;
    }
}
