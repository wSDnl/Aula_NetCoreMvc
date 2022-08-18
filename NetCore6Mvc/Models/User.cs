using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCore6Mvc.Models
{
	[Table("Users")]
	public class User
	{
		[Key]
		public int UserId { get; set; }

		[Required(ErrorMessage = "[ERRO] Informe o nome de usuário")]
		[Display(Name = "Nome User")]
		[StringLength(100,MinimumLength = 10 , ErrorMessage = "[ERRO] o {0} deve conter no mínimo {1} e no máximo {2} ")]
		public string NomeUsuario { get; set; }

		[Required(ErrorMessage = "[ERRO] Informe o E-mail")]
		[Display(Name = "E-mail")]
		[StringLength(100, MinimumLength = 5 , ErrorMessage = "[ERRO] o {0} deve conter no mínimo {1} e no máximo {2} ")]
        public string Email { get; set; }

		[Required(ErrorMessage = "[ERRO] Informe a Senha")]
		[StringLength(100 , MinimumLength = 5 , ErrorMessage = "[ERRO] o {0} deve conter no mínimo {1} e no máximo {2} ")]
		public string Senha { get; set; }

		public bool UsuarioAtivo { get; set; }

    }
}
