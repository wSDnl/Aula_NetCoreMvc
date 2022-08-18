using Microsoft.EntityFrameworkCore;
using NetCore6Mvc.Context;
using NetCore6Mvc.Models;

namespace NetCore6Mvc.Repositories.Interfaces
{
    public class ProdutoRepository : IProdutoRepository
    {

        private readonly AppDbContext _context;
        public ProdutoRepository( AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Produto> Produtos => _context.Produtos.
                                    Include( c => c.Categorias );

        public Produto GetProdutoById(int produtoId)
        {
            return _context.Produtos.FirstOrDefault( p => p.ProdutoId == produtoId );
        }
    }
}
