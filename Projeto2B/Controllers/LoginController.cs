using Microsoft.AspNetCore.Mvc;
using Projeto2B.Repositorio;

namespace Projeto2B.Controllers
{
    public class LoginController : Controller //Herança Controller está herdando a class LoginController e sempre vai ser pública
    {
        //Declarar uma variável privada somente leitura
        private readonly UsuarioRepositorio _usuarioRepositorio;

        //Construtor
        public LoginController(UsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }


        public IActionResult Login() //Recebe os dados do login
        {
            return View();
        }

        [HttpPost]//Envia os dados do login
        public IActionResult Login(string email, string senha)
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
