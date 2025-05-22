using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGameee.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult PageHome()
        {
            return View();
        }
        public ActionResult PageGame()
        {
            return View();
        }
        public ActionResult PageGameDetails()
        {
            return View();
        }

    }
}