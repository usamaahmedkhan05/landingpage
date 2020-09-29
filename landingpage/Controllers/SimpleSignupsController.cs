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
    public class SimpleSignupsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SimpleSignups
        public ActionResult Index()
        {
            return View(db.SimpleSignups.ToList());
        }

        // GET: SimpleSignups/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SimpleSignup simpleSignup = db.SimpleSignups.Find(id);
            if (simpleSignup == null)
            {
                return HttpNotFound();
            }
            return View(simpleSignup);
        }

        // GET: SimpleSignups/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SimpleSignups/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email,Number")] SimpleSignup simpleSignup)
        {
            if (ModelState.IsValid)
            {
                db.SimpleSignups.Add(simpleSignup);
                db.SaveChanges();
                TempData["Message"] = "Thank you";
                return RedirectToAction("Index","Home");
            }
            TempData["Message"] = "Data is not Valid";
            return RedirectToAction("Index", "Home");
        }

        // GET: SimpleSignups/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SimpleSignup simpleSignup = db.SimpleSignups.Find(id);
            if (simpleSignup == null)
            {
                return HttpNotFound();
            }
            return View(simpleSignup);
        }

        // POST: SimpleSignups/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email,Number")] SimpleSignup simpleSignup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(simpleSignup).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(simpleSignup);
        }

        // GET: SimpleSignups/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SimpleSignup simpleSignup = db.SimpleSignups.Find(id);
            if (simpleSignup == null)
            {
                return HttpNotFound();
            }
            return View(simpleSignup);
        }

        // POST: SimpleSignups/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SimpleSignup simpleSignup = db.SimpleSignups.Find(id);
            db.SimpleSignups.Remove(simpleSignup);
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
