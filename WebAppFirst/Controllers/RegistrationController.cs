using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppFirst.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult SignUp(string name, string mail, string pwd)
        {
            if (name != null && mail != null && pwd != null )
            {
                return RedirectToAction("Account", "LogIn");
            }

            List<SelectListItem> li1 = new List<SelectListItem>();
            li1.Add(new SelectListItem { Text = "Please Choose", Value = "Please Choose" });
            li1.Add(new SelectListItem { Text = "Please Choose", Value = "Please Choose " });
            ViewData["Gender"] = li1;

            return View();
        }
        public ActionResult visitorRegister()
        {
            {
                List<SelectListItem> li2 = new List<SelectListItem>();
                li2.Add(new SelectListItem { Text = "Please Choose", Value = "Please Choose" });
                li2.Add(new SelectListItem { Text = "Please Choose", Value = "Please Choose " });
                ViewData["RoadNumber"] = li2;
            }
            {
                List<SelectListItem> li3 = new List<SelectListItem>();
                li3.Add(new SelectListItem { Text = "Please Choose", Value = "Please Choose" });
                li3.Add(new SelectListItem { Text = "Please Choose", Value = "Please Choose " });
                ViewData["Reason"] = li3;

            }

           

            return View();
        }
    }
}