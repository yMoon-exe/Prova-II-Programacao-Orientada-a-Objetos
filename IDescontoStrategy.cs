using LojaVirtual;

namespace LojaVirtual
{
    public interface IDescontoStrategy
{
    decimal CalcularDesconto(Pedido pedido);
}
}

