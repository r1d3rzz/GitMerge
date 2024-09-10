using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitMerge.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            var test = "test";
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }
    }
}