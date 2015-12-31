using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week_10_Lab.Models;

namespace Week_10_Lab.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();

        [HttpPost]
        public JsonResult UploadPin(Pin pin)
        {
            var user = db.Users.Find(User.Identity.GetUserId());
            var pins = user.Pins;
            pins.Add(pin);
            db.SaveChanges();
            return Json(pin);
        }

        [Authorize]
        [HttpGet]
        public ActionResult UploadPin()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult ViewPins(int userId)
        {
            var user = db.Users.Find(userId);
            return Json(user.Pins);
        }
    }
}
