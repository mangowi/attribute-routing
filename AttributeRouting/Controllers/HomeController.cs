using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributeRouting.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        [Route("Products/Index")]
        public ActionResult Index()
        {
            return View();
        }


        [Route("Products/{id}/{name?}")]
        public ActionResult Details(int id, string name)
        {
            return View();
        }

        public ActionResult Deals()
        {
            return View();
        }
    }
}