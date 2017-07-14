using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributeRouting.Controllers
{

    [RoutePrefix("Products")]
    public class HomeController : Controller
    {

        // bit.do/attribute-routing
        // GET: Home

        [Route("Index")]
        public ActionResult Index()
        {
            return View();
        }


        [Route("{id}")]
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Deals()
        {
            return View();
        }
    }
}