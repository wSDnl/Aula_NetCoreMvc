using NetCore6Mvc.Models;

namespace NetCore6Mvc.ViewModels
{
    public class ProdutoListViewModel
    {

        //NÃO FUNCIONOU

        public IEnumerable<Produto> Produtos { get; set; }
        public string CategoriaAtual { get; set; }

    }
}
