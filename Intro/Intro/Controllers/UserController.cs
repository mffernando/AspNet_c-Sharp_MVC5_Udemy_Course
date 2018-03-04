using Intro.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        public ActionResult User(User user)
        {
            //validation
            /*
            //name
            if (string.IsNullOrEmpty(user.Name))
            {
                ModelState.AddModelError("Name", "Name Required!");
            }
            //password
            if (user.Password != user.RepeatPassword)
            {
                ModelState.AddModelError("", "Diferent Passwords!");
            }
            */

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

        public ActionResult UniqueLogin(string login)
        {
            //example array (Collection) logins / generic DB
            var dbExample = new Collection<string>
            {
                "Admin",
                "User",
                "Teste"
            };
            // return a Json
            // registers lowercase
            return Json (dbExample.All(x=>x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }

    }
}