using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace DemoActionFilters.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        [HttpGet]
        [OutputCache(Duration = 40, VaryByParam = "none", Location = OutputCacheLocation.Client, NoStore = true)]
        public string Index()
        {
            return DateTime.Now.ToString("T");

        }
        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";
            throw new Exception("Something went wrong");

            //return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}