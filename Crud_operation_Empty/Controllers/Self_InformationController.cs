using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Crud_operation_Empty.Models;

namespace Crud_operation_Empty.Controllers
{
    public class Self_InformationController : Controller
    {
        private ProductDbContext db = new ProductDbContext();

        // GET: Self_Information
        public ActionResult Index()
        {
            return View(db.self_Information.ToList());
        }

        // GET: Self_Information/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Self_Information self_Information = db.self_Information.Find(id);
            if (self_Information == null)
            {
                return HttpNotFound();
            }
            return View(self_Information);
        }

        // GET: Self_Information/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Self_Information/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Mono")] Self_Information self_Information)
        {
            if (ModelState.IsValid)
            {
                db.self_Information.Add(self_Information);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(self_Information);
        }

        // GET: Self_Information/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Self_Information self_Information = db.self_Information.Find(id);
            if (self_Information == null)
            {
                return HttpNotFound();
            }
            return View(self_Information);
        }

        // POST: Self_Information/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Mono")] Self_Information self_Information)
        {
            if (ModelState.IsValid)
            {
                db.Entry(self_Information).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(self_Information);
        }

        // GET: Self_Information/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Self_Information self_Information = db.self_Information.Find(id);
            if (self_Information == null)
            {
                return HttpNotFound();
            }
            return View(self_Information);
        }

        // POST: Self_Information/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Self_Information self_Information = db.self_Information.Find(id);
            db.self_Information.Remove(self_Information);
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
