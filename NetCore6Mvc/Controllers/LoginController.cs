using Microsoft.AspNetCore.Mvc;

namespace NetCore6Mvc.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
