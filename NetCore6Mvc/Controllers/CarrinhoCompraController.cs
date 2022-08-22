using Microsoft.AspNetCore.Mvc;
using NetCore6Mvc.Models;
using NetCore6Mvc.Repositories.Interfaces;

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
			return View();
		}
	}
}
