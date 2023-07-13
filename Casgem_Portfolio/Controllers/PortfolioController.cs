using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entities;

namespace Casgem_Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        CasgemPortfolioEntities2 db = new CasgemPortfolioEntities2();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            ViewBag.featureTitle = db.TblFeature.Select(x => x.FeatureTitle).FirstOrDefault();
            ViewBag.featureDescription = db.TblFeature.Select(x => x.FeatureDescription).FirstOrDefault();
            ViewBag.feaureImage = db.TblFeature.Select(x => x.FeatureImageURL).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult MyResume()
        {
            var values = db.TblResume.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialStatistic()
        {
            ViewBag.totalService = db.TblService.Count();
            ViewBag.totalMessage = db.TblMessage.Count();
            ViewBag.totalThanksMessage = db.TblMessage.Where(x => x.MessageSubject == "Teşekkür").Count();
            ViewBag.happyCustomer = 12;
            return PartialView();
        }


        public PartialViewResult PartialCommunication()
        {
            ViewBag.communicationPhone = db.TblAboutme.Select(x => x.AboutmePhone).FirstOrDefault();
            ViewBag.communicationEmail = db.TblAboutme.Select(x => x.AboutmeEmail).FirstOrDefault(); ;
            ViewBag.communicationLocation = db.TblAboutme.Select(x => x.AboutmeLocation).FirstOrDefault(); ;
            return PartialView();
        }


        public PartialViewResult PartialVideo()
        {
            //  ViewBag.videoTitle1 = db.TblAboutme.Select(x => x.VideoTitle1).FirstOrDefault();
            //  ViewBag.videoTitle2 = db.TblAboutme.Select(x => x.VideoTitle2).FirstOrDefault(); ;
            ////  ViewBag.communicationLocation = db.TblAboutme.Select(x => x.AboutmeLocation).FirstOrDefault(); ;
            //  return PartialView();

            var values = db.TblAboutme.ToList();
            return PartialView(values);
        }


        public PartialViewResult PartialWhoAmI()
        {
           
            ViewBag.WhoAmIName = db.TblAboutme.Select(x => x.AboutmeName).FirstOrDefault(); ;
            ViewBag.WhoAmIDetail = db.TblAboutme.Select(x => x.AboutmeDetail).FirstOrDefault(); ;
            return PartialView();
        }


        public PartialViewResult PartialService()
        {

            var values = db.TblService.ToList();
            return PartialView(values);
        }


        public PartialViewResult PartialTeacher()
        {

            var values = db.TblTeacher.ToList();
            return PartialView(values);
        }


     




    }
}