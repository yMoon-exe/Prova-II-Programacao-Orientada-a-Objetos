using LojaVirtual;

namespace LojaVirtual
{
    public class Cliente : ICliente
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Email { get; private set; }
    public string CPF { get; private set; }

    public Cliente(int id, string nome, string email, string cpf)
    {
        if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(cpf))
            throw new ArgumentException("Dados do cliente inválidos.");

        Id = id;
        Nome = nome;
        Email = email;
        CPF = cpf;
    }
}
}

