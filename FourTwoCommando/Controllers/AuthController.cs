using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FourTwoCommando.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<AuthController> _logger;

        public AuthController(ILogger<AuthController> logger)
        {
            _logger = logger;
        }
        
        // GET
        public ActionResult LogIn()
        {
            return View();
        }
    }
}