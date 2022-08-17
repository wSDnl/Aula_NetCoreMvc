namespace NetCore6Mvc.Models
{
    public class Categorias
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        public List<Produto> Produto { get; set; }

    }
}
