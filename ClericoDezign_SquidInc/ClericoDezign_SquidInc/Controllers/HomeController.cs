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

        public ActionResult PageNotFound()
        {
            return RedirectToAction("Error", "Page Not Found");
        }

        public ActionResult TestError()
        {
            return Error();
        }

        public ActionResult Test404()
        {
            return Redirect("PageNotFound");
        }

    }
}
