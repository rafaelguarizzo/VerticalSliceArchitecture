using Microsoft.EntityFrameworkCore;
using VerticalSliceProduto.Api.Infraestructures.Context;

namespace VerticalSliceProduto.Api.Features.Produto;

public class ProdutoRepository
{
    private readonly ProdutoDbContext _context;

    public ProdutoRepository(ProdutoDbContext context)
    {
        _context = context;
    }

    public async Task<List<Domain.Produto>> GetAllAsync()
    {
        return await _context.Produtos.ToListAsync();
    }
    
    public async Task<Domain.Produto?> GetByIdAsync(Guid id)
    {
        return await _context.Produtos.FindAsync(id);
    }
    
    public async Task AddAsync(Domain.Produto produto)
    {
        await _context.Produtos.AddAsync(produto);
        await _context.SaveChangesAsync();
    }
    
    public async Task UpdateAsync(Domain.Produto produto)
    {
         _context.Produtos.Update(produto);
         await _context.SaveChangesAsync();
         
    }
    
    public async Task DeleteAsync(Domain.Produto produto)
    {
        _context.Produtos.Remove(produto);
        await _context.SaveChangesAsync();
         
    }
}