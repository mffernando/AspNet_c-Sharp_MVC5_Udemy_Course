using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(); // return > Views > Home > Index.chstml
        }

        //new view Contacts (Views > Home > Contacts)
        public ActionResult Contacts()
        {
            return View(); // return > Views > Home > Contacts.cshtml
        }
    }
}