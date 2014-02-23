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
            int code = 0;
            int.TryParse(errorMessage, out code);

            switch (code)
            {
                case 403:
                    return View("Error", "403 Forbidden");
                case 404:
                    return View("Error", "404 Page Not Found");
                case 500:
                    return View("Error", "500 Internal Server Error");
                default:
                    return View("Error");

            }
        }

        public ActionResult Test403()
        {
            return new HttpStatusCodeResult(403);
        }

        public ActionResult Test404()
        {
            return new HttpStatusCodeResult(404);
        }

        public ActionResult Test500()
        {
            return new HttpStatusCodeResult(500);
        }

        public ActionResult TestGeneralError()
        {
            return Error();
        }

    }
}
