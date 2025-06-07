public class Produto : IProduto
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public decimal Preco { get; private set; }
    public string Categoria { get; private set; }

    public Produto(int id, string nome, decimal preco, string categoria)
    {
        if (string.IsNullOrWhiteSpace(nome) || preco <= 0)
            throw new ArgumentException("Dados do produto inválidos.");

        Id = id;
        Nome = nome;
        Preco = preco;
        Categoria = categoria;
    }
}
