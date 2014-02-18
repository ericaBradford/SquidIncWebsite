using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClericoDezign_SquidInc.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Error(string errorMessage = "")
        {
            return View("Error", (object)errorMessage);
        }

    }
}
