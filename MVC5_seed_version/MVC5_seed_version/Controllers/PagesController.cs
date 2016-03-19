using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_seed_version.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult PagesBlank()
        {
            return View();
        }
        public ActionResult PagesAnotherBlank()
        {
            return View();
        }
    }
}