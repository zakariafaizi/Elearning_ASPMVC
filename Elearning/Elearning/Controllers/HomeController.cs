using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Elearning.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            Session["username"] = null;
            Session["password"] = null;

            return RedirectToAction("Home", "Student");
        }
    }
}