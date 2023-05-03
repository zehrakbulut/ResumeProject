using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class DefaultController : Controller
    {

        DbResumeEntities2 db = new DbResumeEntities2();

        public PartialViewResult PartialSkills()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTechnology()
        {
            var values = db.TblTechnology.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialBrands()
        {
            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }

        public PartialViewResult PartialScripts()
        {
            return PartialView();
        }

        public PartialViewResult PartialProjects()
        {
            return PartialView();
        }
            
        public PartialViewResult PartialCounter()
        {
            ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.serviceCount = db.TblService.Count();
            ViewBag.avgTechnologyValue = db.TblTechnology.Average(x => x.TechnologyValue);
            ViewBag.happyCustomer = 38;
            return PartialView();
        }

        public PartialViewResult PartialService()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.TblProfile.ToList();
            return PartialView(values);
        }
        
        public ActionResult Index()
        {
            return View();
        }
        
        public PartialViewResult Partial1()
        {
            return PartialView();
        }

        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }

    }
}