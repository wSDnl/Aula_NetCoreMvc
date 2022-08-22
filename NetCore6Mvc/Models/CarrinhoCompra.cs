using NetCore6Mvc.Context;

namespace NetCore6Mvc.Models
{
	public class CarrinhoCompra
	{




		private readonly AppDbContext _context;

		public CarrinhoCompra(AppDbContext context)
		{
			_context = context;
		}




		public string CarrinhoCompraId { get; set; }

		public List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }



				public static CarrinhoCompra GetCarrinho(IServiceProvider services)
				{
					// DEFINE UMA SESSÃO
					ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;


					// OBTEM UM SERVIÇO DO TIPO DO NOSSO CONTEXTO
					var context = services.GetService<AppDbContext>();


					// OBTER OU GERAR O ID DO CARRINHO
					string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();


					// ATRIBUI O ID DO CARRINHO NA SESSÃO
					session.SetString("CarrinhoId", carrinhoId);


					return new CarrinhoCompra(context)
					{
						CarrinhoCompraId = carrinhoId
					};

				}

        /// *** METODOS *** ///


				public void AdicionarAoCarrinho(Produto produto)
				{
					var carrinhoCompraItem = _context.CarrinhoCompraItens.SingleOrDefault(
						s=>	s.Produto.ProdutoId == produto.ProdutoId &&
						s.CarrinhoCompraId == CarrinhoCompraId
					);


						if (carrinhoCompraItem == null)
						{
							carrinhoCompraItem = new CarrinhoCompraItem
							{
								CarrinhoCompraId = CarrinhoCompraId,
								Produto = produto,
								Quantidade = 1,
							};

							_context.CarrinhoCompraItens.Add(carrinhoCompraItem);

						} else {
							carrinhoCompraItem.Quantidade++;
						}

						_context.SaveChanges();

				}


        /// *** /METODOS *** ///

	}
}
