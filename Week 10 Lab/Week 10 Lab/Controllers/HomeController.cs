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
            
            db.Pins.Add(pin);
            db.SaveChanges();
            return Json(pin);
        }
        
        [HttpGet]
        public ActionResult Pinterest()
        {
            return View();
        }
        
        [HttpGet]
        public JsonResult GetPins()
        {
            return Json(db.Pins.ToList(), JsonRequestBehavior.AllowGet);    
        }
    }
}
