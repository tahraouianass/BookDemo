using Microsoft.AspNetCore.Mvc;

namespace WebBook.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
