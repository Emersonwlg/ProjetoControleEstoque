using Microsoft.EntityFrameworkCore;
using ProjetoEstoque.Models;

namespace ProjetoEstoque.Models
{
    public class EstoqueDbContext : DbContext
    {
        public EstoqueDbContext(DbContextOptions<EstoqueDbContext> options) : base(options)
        {}
        public DbSet<Produto> Produtos {get;set;}
    }
}