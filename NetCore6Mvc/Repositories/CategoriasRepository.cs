using NetCore6Mvc.Context;
using NetCore6Mvc.Models;
using NetCore6Mvc.Repositories.Interfaces;

namespace NetCore6Mvc.Repositories
{
    public class CategoriasRepository : ICategoriasRepository
    {

        private readonly AppDbContext _context;

        public CategoriasRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Categorias> Categorias => _context.Categorias;

    }
}
