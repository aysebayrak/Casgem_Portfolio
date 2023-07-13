using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entities;

namespace Casgem_Portfolio.Controllers
{
    public class ReferenceController : Controller
    {
        CasgemPortfolioEntities2 db = new CasgemPortfolioEntities2();
        public ActionResult Index()
        {
            var values = db.TblReference.ToList();
            return View(values);
        }

        public ActionResult DeleteReference(int id)
        {
            var value = db.TblReference.Find(id);
            db.TblReference.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult UpdateReference(int id)
        {
            var value = db.TblReference.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateReference(TblReference p)
        {
            var value = db.TblReference.Find(p.ReferenceID);
            value.ReferenceName = p.ReferenceName;
            value.ReferenceProne = p.ReferenceProne;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}