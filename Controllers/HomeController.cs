using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace doranekoWebAspCSharp.Controllers
{
    [MyFilter]
    public class HomeController : Controller
    {
        //
        // GET: /home/
        [OutputCache(Duration=15)]
        public ActionResult Index()
        {
            return View();
        }
	}
}