namespace NetCore6Mvc.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public string Valor { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemMini { get; set; }
        public bool Disponivel { get; set; }
        public string QtdeEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categorias Categorias { get; set; }

    }
}
