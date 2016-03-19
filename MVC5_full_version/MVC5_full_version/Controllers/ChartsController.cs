using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_full_version.Controllers
{
    public class ChartsController : Controller
    {
        // GET: Charts
        public ActionResult ChartJS()
        {
            return View();
        }
        public ActionResult CS3Charts()
        {
            return View();
        }
        public ActionResult MorrisJS()
        {
            return View();
        }
        public ActionResult Sparkline()
        {
            return View();
        }
    }
}