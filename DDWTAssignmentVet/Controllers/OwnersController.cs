using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDWTAssignmentVetCMS.Controllers
{
    public class OwnersController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Active = "Owners";
            return View();
        }

        public ActionResult Details()
        {
            ViewBag.Active = "Owners";
            return View();
        }
    }
}