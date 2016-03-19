using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5_full_version.Controllers
{
    public class FormsController : Controller
    {
        // GET: Forms
        public ActionResult Components()
        {
            return View();
        }
        public ActionResult Validation()
        {
            return View();
        }
        public ActionResult Mask()
        {
            return View();
        }
        public ActionResult Wizard()
        {
            return View();
        }
        public ActionResult MultipleFileUpload()
        {
            return View();
        }
        public ActionResult WYSIWYGEditor()
        {
            return View();
        }
    }
}