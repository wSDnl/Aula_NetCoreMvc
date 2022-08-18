using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore6Mvc.Models
{
    [Table("Categorias")]
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage ="[ERRO] Informe o nome da categoria")]
        [StringLength(100,ErrorMessage ="[ERRO] O tamanho máximo é de 100 caracteres")]
        public string CategoriaNome { get; set; }

        [Required(ErrorMessage ="[ERRO] Informe a descrição da categoria")]
        [StringLength(200,ErrorMessage = "[ERRO] O tamanho máximo é de 200 caracteres")]
        public string Descricao { get; set; }



        public List<Produto> Produto { get; set; }



    }
}
