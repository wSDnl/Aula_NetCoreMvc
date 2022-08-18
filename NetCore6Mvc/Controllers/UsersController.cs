using Microsoft.AspNetCore.Mvc;
using NetCore6Mvc.Repositories.Interfaces;

namespace NetCore6Mvc.Controllers
{
	public class UsersController : Controller
	{

		private readonly IUserRepository _UsersRepository;

		public UsersController(IUserRepository usersRepository)
		{
			_UsersRepository = usersRepository;
		}

		public IActionResult List()
		{
			var users = _UsersRepository.Users;
			return View(users);
		}
	}
}
