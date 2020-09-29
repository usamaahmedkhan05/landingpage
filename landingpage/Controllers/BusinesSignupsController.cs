using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using landingpage.Models;

namespace landingpage.Controllers
{
    public class BusinesSignupsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: BusinesSignups
        public ActionResult Index()
        {
            return View(db.BusinesSignups.ToList());
        }

        // GET: BusinesSignups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinesSignup businesSignup = db.BusinesSignups.Find(id);
            if (businesSignup == null)
            {
                return HttpNotFound();
            }
            return View(businesSignup);
        }

        // GET: BusinesSignups/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusinesSignups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,BusinessName,CompanyName,Name,Email,Number,Title")] BusinesSignup businesSignup)
        {
            if (ModelState.IsValid)
            {
                db.BusinesSignups.Add(businesSignup);
                db.SaveChanges();
                TempData["Message"] = "Thank you";
                return RedirectToAction("Partner", "Home");
            }

            TempData["Message"] = "Data is not Valid";
            return RedirectToAction("Partner", "Home");
        }

        // GET: BusinesSignups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinesSignup businesSignup = db.BusinesSignups.Find(id);
            if (businesSignup == null)
            {
                return HttpNotFound();
            }
            return View(businesSignup);
        }

        // POST: BusinesSignups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,BusinessName,CompanyName,Name,Email,Number,Title")] BusinesSignup businesSignup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(businesSignup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(businesSignup);
        }

        // GET: BusinesSignups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BusinesSignup businesSignup = db.BusinesSignups.Find(id);
            if (businesSignup == null)
            {
                return HttpNotFound();
            }
            return View(businesSignup);
        }

        // POST: BusinesSignups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BusinesSignup businesSignup = db.BusinesSignups.Find(id);
            db.BusinesSignups.Remove(businesSignup);
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
