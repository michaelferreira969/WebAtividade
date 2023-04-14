using Biblioteca_MCF.Models;
using Microsoft.AspNetCore.Mvc;

namespace Biblioteca_MCF.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult List()
        {
            return View();
        }
    }
}
