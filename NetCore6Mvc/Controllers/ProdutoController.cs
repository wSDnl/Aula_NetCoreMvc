using Microsoft.AspNetCore.Mvc;
using NetCore6Mvc.Repositories.Interfaces;

namespace NetCore6Mvc.Controllers
{
    public class ProdutoController : Controller
    {

        private readonly IProdutoRepository _produtoRepositorio;

        public ProdutoController(IProdutoRepository produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public IActionResult List()
        {
            var produto = _produtoRepositorio.Produtos;
            return View(produto);

        }

        public IActionResult Card() 
        {
            ViewData["Titulo"] = "Produtos Cards";
            ViewData["DataHora"] = DateTime.Now;
            var cardProduto = _produtoRepositorio.Produtos;
            var totalProdutos = cardProduto.Count();

            ViewBag.TextoTotalProdutos = "Total de produtos: ";
            ViewBag.TotalProdutos = totalProdutos;

            return View(cardProduto);
        }


    }
}
