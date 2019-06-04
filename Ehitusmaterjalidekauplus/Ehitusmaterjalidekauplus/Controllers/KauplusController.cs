using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ehitusmaterjalidekauplus.Controllers
{
    public class KauplusController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: Kauplus
        public ActionResult Index()
        {
            return View(db.Kauplus.ToList());
        }
    }
}