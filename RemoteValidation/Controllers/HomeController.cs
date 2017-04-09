using RemoteValidation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RemoteValidation.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Remote Validation";
            return View();
        }

        [HttpPost]
        public string Index(SampleModel data)
        {
            return "saved";
        }

        public JsonResult CheckValidIP(string clientIp)
        {
            return Json(clientIp == "127.0.0.1", JsonRequestBehavior.AllowGet);
        }


    }
}