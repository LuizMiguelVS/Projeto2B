using Microsoft.AspNetCore.Mvc;

namespace Projeto2B.Controllers
{
    public class LoginController : Controller //Herança Controller está herdando a class LoginController 
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
