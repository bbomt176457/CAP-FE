using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CapK23t_WebApp_2020.Controllers
{
    public class ManageStudentController : Controller
    {
        // GET: ManageStudent
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CreateListStudent()
        {
            return View();
        }
    }
}