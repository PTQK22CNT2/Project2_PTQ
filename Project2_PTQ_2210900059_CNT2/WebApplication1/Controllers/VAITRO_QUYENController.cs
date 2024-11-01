using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class VAITRO_QUYENController : Controller
    {
        private project2_PTQEntities1 db = new project2_PTQEntities1();

        // GET: VAITRO_QUYEN
        public ActionResult Index()
        {
            return View(db.VAITRO_QUYEN.ToList());
        }

        // GET: VAITRO_QUYEN/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VAITRO_QUYEN vAITRO_QUYEN = db.VAITRO_QUYEN.Find(id);
            if (vAITRO_QUYEN == null)
            {
                return HttpNotFound();
            }
            return View(vAITRO_QUYEN);
        }

        // GET: VAITRO_QUYEN/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VAITRO_QUYEN/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Ma_VT,Ten_VT,Ma_Quyen")] VAITRO_QUYEN vAITRO_QUYEN)
        {
            if (ModelState.IsValid)
            {
                db.VAITRO_QUYEN.Add(vAITRO_QUYEN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vAITRO_QUYEN);
        }

        // GET: VAITRO_QUYEN/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VAITRO_QUYEN vAITRO_QUYEN = db.VAITRO_QUYEN.Find(id);
            if (vAITRO_QUYEN == null)
            {
                return HttpNotFound();
            }
            return View(vAITRO_QUYEN);
        }

        // POST: VAITRO_QUYEN/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Ma_VT,Ten_VT,Ma_Quyen")] VAITRO_QUYEN vAITRO_QUYEN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vAITRO_QUYEN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vAITRO_QUYEN);
        }

        // GET: VAITRO_QUYEN/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VAITRO_QUYEN vAITRO_QUYEN = db.VAITRO_QUYEN.Find(id);
            if (vAITRO_QUYEN == null)
            {
                return HttpNotFound();
            }
            return View(vAITRO_QUYEN);
        }

        // POST: VAITRO_QUYEN/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VAITRO_QUYEN vAITRO_QUYEN = db.VAITRO_QUYEN.Find(id);
            db.VAITRO_QUYEN.Remove(vAITRO_QUYEN);
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
