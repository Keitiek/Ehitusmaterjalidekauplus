using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Ehitusmaterjalidekauplus.Models;

namespace Ehitusmaterjalidekauplus.Controllers
{
    public class ToodedsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Toodeds
        public ActionResult Index()
        {
            return View(db.Toodeds.ToList());
        }

        // GET: Toodeds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tooded tooded = db.Toodeds.Find(id);
            if (tooded == null)
            {
                return HttpNotFound();
            }
            return View(tooded);
        }

        // GET: Toodeds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Toodeds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Toode,Hind,Jääk")] Tooded tooded)
        {
            if (ModelState.IsValid)
            {
                db.Toodeds.Add(tooded);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tooded);
        }

        // GET: Toodeds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tooded tooded = db.Toodeds.Find(id);
            if (tooded == null)
            {
                return HttpNotFound();
            }
            return View(tooded);
        }

        // POST: Toodeds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Toode,Hind,Jääk")] Tooded tooded)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tooded).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tooded);
        }

        // GET: Toodeds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tooded tooded = db.Toodeds.Find(id);
            if (tooded == null)
            {
                return HttpNotFound();
            }
            return View(tooded);
        }

        // POST: Toodeds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tooded tooded = db.Toodeds.Find(id);
            db.Toodeds.Remove(tooded);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
