using MeetingApp.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        [HttpGet] //default
        public IActionResult Apply(){
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo user){
            if(ModelState.IsValid){
            Repository.CreateUser(user);
            int userCount=Repository.Users.Where(user=>user.WillAttend==true).Count();
            ViewBag.Message = userCount >=2?$"Toplantıya sizinle beraber {userCount} kişi katılıyor.":"Şu anda tek katılımcı sizsiniz.";
            return View("Thanks",user);
            }
            else{
                return View(user);
            }
        }
        public IActionResult List(){
            return View(Repository.Users);
        }

        public IActionResult Detail(int? id){
            if(id is null){
                RedirectToAction("list","meeting");
            }
            return View(Repository.GetById(id));
        }
    }
}