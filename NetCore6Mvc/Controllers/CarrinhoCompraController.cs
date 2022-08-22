using Microsoft.AspNetCore.Mvc;
using NetCore6Mvc.Models;
using NetCore6Mvc.Repositories.Interfaces;
using NetCore6Mvc.ViewModels;

namespace NetCore6Mvc.Controllers
{
	public class CarrinhoCompraController : Controller
	{

		private readonly IProdutoRepository _produtoRepository;
		private readonly CarrinhoCompra _carrinhoCompraController;

		public CarrinhoCompraController(IProdutoRepository produtoRepository, CarrinhoCompra carrinhoCompraController)
		{
			_produtoRepository = produtoRepository;
			_carrinhoCompraController = carrinhoCompraController;
		}

		public IActionResult Index()
		{
			var itens = _carrinhoCompraController.GetCarrinhoCompraItens();	
			_carrinhoCompraController.CarrinhoCompraItens = itens;

			var carrinhoCompraVM = new CarrinhoCompraViewModel
			{
				CarrinhoCompra = _carrinhoCompraController,
				CarrinhoCompraTotal = _carrinhoCompraController.GetCarrinhoCompraTotal()
			};

			return View(carrinhoCompraVM);
		}

		public IActionResult AdicionarItemNoCarrinhoCompra(int produtoId)
		{
			var produtoSelecionado = _produtoRepository.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);
			if (produtoSelecionado != null)
			{
				_carrinhoCompraController.AdicionarAoCarrinho(produtoSelecionado);
			}

		return RedirectToAction("Index");

		}


		public IActionResult RemoverItemDoCarrinhoCompra(int produtoId)
		{
            var produtoSelecionado = _produtoRepository.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);
            if (produtoSelecionado != null)
            {
				_carrinhoCompraController.RemoverDoCarrinho(produtoSelecionado);
            }

            return RedirectToAction("Index");
        }


	}
}
