using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            int time = DateTime.Now.Hour;
            ViewBag.Message = time>12?"İyi Günler":"Günaydın";
            ViewData["username"]="Ali";
            return View();
        }
    }
}