using NetCore6Mvc.Context;
using NetCore6Mvc.Models;
using NetCore6Mvc.Repositories.Interfaces;

namespace NetCore6Mvc.Repositories
{
	public class UserRepository : IUserRepository
	{
		private readonly AppDbContext _context;

		public UserRepository(AppDbContext context)
		{
			_context = context;
		}

		public IEnumerable<User> Users => _context.Users;

    }
}
