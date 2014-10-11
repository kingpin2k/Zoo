using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Zoo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            var debug = false;
#if DEBUG
            debug = true;
#endif
            ViewBag.debug = debug;
            return View();
        }

    }
}
