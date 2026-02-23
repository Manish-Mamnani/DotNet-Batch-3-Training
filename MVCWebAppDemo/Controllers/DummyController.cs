using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWebAppDemo.Controllers
{
    public class DummyController : Controller
    {
        // GET: Dummy
        //Action Method
        public ActionResult Index()
        {
            List<string> nameList = new List<string>()
            {
                "Alok","Rajat","Mahi"
            };

            ViewBag.Names = nameList;

            return View();
        }
    }
}