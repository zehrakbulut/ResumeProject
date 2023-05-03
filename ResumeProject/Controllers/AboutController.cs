using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class AboutController : Controller
    {
        DbResumeEntities2 db = new DbResumeEntities2();

        public ActionResult Index()
        {
            return View();
        }


    }
}