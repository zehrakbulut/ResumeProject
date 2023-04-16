using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class TechnologyController : Controller
    {
        DbResumeEntities db=new DbResumeEntities();
        public ActionResult Index()
        {
            var values = db.TblTechnology.ToList();
            return View(values);
        } 
    }
}