using NetCore6Mvc.Models;

namespace NetCore6Mvc.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Produtos { get; }

        Produto GetProdutoById(int produtoId);

    }
}
