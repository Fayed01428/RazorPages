using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DDWTAssignmentVetCMS.Controllers
{
    public class EnrolmentsController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Active = "Enrolments";
            return View();
        }
 
    }
}