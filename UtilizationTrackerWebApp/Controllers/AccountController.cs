using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UtilizationTrackerWebApp.Models.Data;
using UtilizationTrackerWebApp.Utility;

namespace UtilizationTrackerWebApp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            SessionComponent.UID = 1 ;
            SessionComponent.UName = "Deepak Rana";
            SessionComponent.RoleName = "Manager";

            return RedirectToAction("Index","Client");
        }

        public ActionResult Login2()
        {
            SessionComponent.UID = 1;
            SessionComponent.UName = "Deepak Rana";
            SessionComponent.RoleName = "User";

            return RedirectToAction("Index", "Client");
        }

        [HttpPost]
        public ActionResult Login(Login_Model MyModel)
        {
            return View();
        }
        public ActionResult LogOut()
        {
            SessionComponent.ClearSession();

            return View("Login");
        }

        public ActionResult UnAuthorized()
        {
    
            return View();
        }

        public ActionResult CustomError()
        {

            return View();
        }
        
    }
}