using Microsoft.EntityFrameworkCore;
using VerticalSliceProduto.Api.Domain;

namespace VerticalSliceProduto.Api.Infraestructures.Context;

public class ProdutoDbContext : DbContext
{
    public ProdutoDbContext(DbContextOptions options) : base(options)
    {
            
    }

    public DbSet<Produto> Produtos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Produto>().HasKey(o => o.Id);
        base.OnModelCreating(modelBuilder);
    }
}