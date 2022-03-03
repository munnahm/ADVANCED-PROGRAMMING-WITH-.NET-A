using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyCV.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        public ActionResult registration()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
    }
}