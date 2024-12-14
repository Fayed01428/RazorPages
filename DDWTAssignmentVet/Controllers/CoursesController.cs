using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDWTAssignmentVetCMS.Controllers
{
    public class CoursesController : Controller
    {
        // GET: /Parameter/Index?id=5
        // where id is the paramID
        public ActionResult Index()
        {
            ViewBag.Active = "Courses";
            return View();
        }

        // GET: /Parameter/Details?id=5
        // where id is the paramID
        public ActionResult Details()
        {
            ViewBag.Active = "Courses";
            return View();
        }
    }
}