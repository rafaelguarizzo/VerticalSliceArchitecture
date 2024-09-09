using Microsoft.AspNetCore.Http.HttpResults;

namespace VerticalSliceProduto.Api.Domain;

public class Produto
{
    public Guid Id { get; private set; }
    public string? Nome { get; private set; }
    public Decimal Preco { get; private set; } = Decimal.Zero;
    public DateTime DataCriacao { get; private set; }
    public DateTime? DataAtualizacao { get; private set; }
    public DateTime? DataDelecao { get; private set; }

    public Produto(string nome, Decimal preco)
    {
        Id = Guid.NewGuid();
        Nome = nome;
        Preco = preco;
        DataCriacao = DateTime.UtcNow;
    }

    public void Update(string nome, Decimal preco)
    {
        Nome = nome;
        Preco = preco;
        DataAtualizacao = DateTime.UtcNow;
    }
    
    public void Delete()
    {
        DataDelecao = DateTime.UtcNow;
    }
    
}