using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppFirst.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult LogIn(string username, string pwd)
        {
            if(username != null && pwd != null)
            {
                return RedirectToAction("Dashboard", "Home");
            }
           
            return View();
        }
      
    }
}