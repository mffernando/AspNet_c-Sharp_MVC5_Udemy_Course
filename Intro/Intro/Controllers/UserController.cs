using Intro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Intro.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult User()
        {
            var user = new User();
            return View(user); //return user view
        }

        [HttpPost]
        public ActionResult Index(User user)
        {
            //validation
            if (ModelState.IsValid)
            { //if true
                return View("Result", user);
            } //if false
            return View(user);
        }

        public ActionResult Result(User user)
        {
            return View(user);
        }

    }
}