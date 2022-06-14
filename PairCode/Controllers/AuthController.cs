using Microsoft.AspNetCore.Mvc;

namespace PairCode.Controllers
{
    public class AuthController : Controller
    {
        public ViewResult Login()
        {
            return View();
        }
        public ViewResult Signup()
        {
            return View();
        }
    }
}
