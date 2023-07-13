using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Casgem_Portfolio.Models.Entities;

namespace Casgem_Portfolio.Controllers
{
    public class AboutmeController : Controller
    {
        CasgemPortfolioEntities2 db = new CasgemPortfolioEntities2();
        public ActionResult Index()
        {
            var values = db.TblAboutme.ToList();
            return View(values);
        }
    }
}