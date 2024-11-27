using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzPr.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
