using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hartford.Web.Controllers
{
    public class PavingController : Controller
    {
        //
        // GET: /Paving/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AboutPaving()
        {
            return View();
        }
        public ActionResult PavingServices()
        {
            return View();
        }
        public ActionResult FinishedPaving()
        {
            return View();
        }

    }
}
