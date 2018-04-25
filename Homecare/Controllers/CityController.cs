using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homecare.Controllers
{
    public class CityController : Controller
    {
        // GET: City
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateCity()
        {
            return View();
        }
    }
}