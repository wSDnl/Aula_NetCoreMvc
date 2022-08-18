using NetCore6Mvc.Models;

namespace NetCore6Mvc.Repositories.Interfaces
{
	public interface IUserRepository
	{
		IEnumerable<User> Users { get; }
	}
}
