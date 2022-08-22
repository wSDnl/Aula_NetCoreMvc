using Microsoft.EntityFrameworkCore;
using NetCore6Mvc.Models;

namespace NetCore6Mvc.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }

    }
}
