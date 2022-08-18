using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore6Mvc.Models
{

    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage ="[ERRO] Informe o nome do poduto")]
        [Display(Name="Nome do Produto")]
        [StringLength(100, MinimumLength = 10, ErrorMessage ="[ERRO] O {0} deve ter no mínimo {1} e no máxinmo {2} ")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage ="[ERRO] Informe a descrição curta do produto")]
        [Display(Name ="Descrição curta do Produto")]
        [StringLength(100, MinimumLength = 10 , ErrorMessage ="[ERRO] O {0} deve ter no mínimo {1} e no máximo {2} ")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage ="[ERRO] Informe a descrição detalhada do produto")]
        [Display(Name ="Descrição detalhada do Produto")]
        [StringLength(100, MinimumLength = 10 , ErrorMessage ="[ERRO] O {0} deve ter no mínimo {1} e no máximo {2} ")]
        public string DescricaoDetalhada { get; set; }

        [Required(ErrorMessage ="[ERRO] Informe o valor do produto")]
        [Display(Name ="Preço")]
        [Column(TypeName ="decimal(10,2)")]
        [Range(1,999.99,ErrorMessage ="O valor de estar entre 1 e 999,99")]
        public decimal Valor { get; set; }


        public string ImagemUrl { get; set; }


        public string ImagemMini { get; set; }


        public bool Disponivel { get; set; }

        [Required]
        [Display(Name ="Quantidade do produto em estoque")]
        public string QtdeEstoque { get; set; }


        [Required(ErrorMessage ="[ERRO] Defina a categoria do produto")]
        public int CategoriaId { get; set; }


        public virtual Categorias Categorias { get; set; }



    }
}
