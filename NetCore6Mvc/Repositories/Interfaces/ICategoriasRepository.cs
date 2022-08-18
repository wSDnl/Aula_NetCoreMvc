using NetCore6Mvc.Models;

namespace NetCore6Mvc.Repositories.Interfaces
{
    public interface ICategoriasRepository
    {
        IEnumerable<Categorias> Categorias { get; }
    }
}
