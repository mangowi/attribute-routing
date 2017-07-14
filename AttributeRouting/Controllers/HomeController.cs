using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributeRouting.Controllers
{

    [RoutePrefix("Products")]
    [Route("{action=index}")]
    public class HomeController : Controller
    {

        // bit.do/attribute-routing
        // GET: Home
       
        public ActionResult Index()
        {
            return View();
        }


        [Route("{id}")]
        public ActionResult Details(int id)
        {
            return View();
        }

        [Route("/~Deals")]
        public ActionResult Deals()
        {
            return View();
        }
    }
}