using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(){
            int time = DateTime.Now.Hour;
            ViewBag.Message = time>12?"İyi Günler":"Günaydın";
            ViewData["username"]="Ali";

            var meetingInfo = new MeetingInfo(){
                ID=1,
                Location="Ankara, EBS Otel",
                Date= new DateTime(2024,1,20,20,0,0),
                NumberOfPeople=100
            };
            return View(meetingInfo);
        }
    }
}