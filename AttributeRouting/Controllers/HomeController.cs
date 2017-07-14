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
       [Route("Index", Name = "ProductIndex", Order = 2)]
        public ActionResult Index()
        {
            return View();
        }


        //[Route("{id}")]
        [Route("{id}", Name = "ProductDetails", Order = 1)]
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