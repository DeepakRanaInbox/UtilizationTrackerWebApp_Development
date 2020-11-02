using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using UtilizationTrackerWebApp.Utility;

namespace UtilizationTrackerWebApp.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        [MyExceptionFilter]
        public ActionResult Index()
        {

            throw new Exception("Custome");

            try
            {
                throw new Exception("");
            }
            catch(Exception EXC)
            {
                Error_Component.WriteErrorLogInFile(EXC, "UtilizationTrackerWebApp", "Demo", "Index", "", "", "");
            }

            return View();
        }
    }
}