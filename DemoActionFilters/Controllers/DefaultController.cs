using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoActionFilters.Controllers
{

    [Authorize]
    public class DefaultController : Controller
    {
        [AllowAnonymous]
        public ActionResult NonSecureMethod()
        {
            return View();
        }
        public ActionResult SecureMethod()
        {
            return View();
        }
    }
}