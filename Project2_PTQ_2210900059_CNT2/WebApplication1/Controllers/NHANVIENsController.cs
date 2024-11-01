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
    public class NHANVIENsController : Controller
    {
        private project2_PTQEntities db = new project2_PTQEntities();

        // GET: NHANVIENs
        public ActionResult Index()
        {
            var nHANVIENs = db.NHANVIENs.Include(n => n.CHUCVU).Include(n => n.PHONGBAN);
            return View(nHANVIENs.ToList());
        }

        // GET: NHANVIENs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHANVIEN nHANVIEN = db.NHANVIENs.Find(id);
            if (nHANVIEN == null)
            {
                return HttpNotFound();
            }
            return View(nHANVIEN);
        }

        // GET: NHANVIENs/Create
        public ActionResult Create()
        {
            ViewBag.Ma_chuc_vu = new SelectList(db.CHUCVUs, "Ma_CV", "Ten_CV");
            ViewBag.Ma_Phong = new SelectList(db.PHONGBANs, "Ma_phong", "Ten_Phong");
            return View();
        }

        // POST: NHANVIENs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Ma_NV,Ho_Ten,Ngay_Sinh,Gioi_Tinh,Ma_Phong,SDT,Dia_Chi,Email,Ngay_Lam,Ma_chuc_vu")] NHANVIEN nHANVIEN)
        {
            if (ModelState.IsValid)
            {
                db.NHANVIENs.Add(nHANVIEN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Ma_chuc_vu = new SelectList(db.CHUCVUs, "Ma_CV", "Ten_CV", nHANVIEN.Ma_chuc_vu);
            ViewBag.Ma_Phong = new SelectList(db.PHONGBANs, "Ma_phong", "Ten_Phong", nHANVIEN.Ma_Phong);
            return View(nHANVIEN);
        }

        // GET: NHANVIENs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHANVIEN nHANVIEN = db.NHANVIENs.Find(id);
            if (nHANVIEN == null)
            {
                return HttpNotFound();
            }
            ViewBag.Ma_chuc_vu = new SelectList(db.CHUCVUs, "Ma_CV", "Ten_CV", nHANVIEN.Ma_chuc_vu);
            ViewBag.Ma_Phong = new SelectList(db.PHONGBANs, "Ma_phong", "Ten_Phong", nHANVIEN.Ma_Phong);
            return View(nHANVIEN);
        }

        // POST: NHANVIENs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Ma_NV,Ho_Ten,Ngay_Sinh,Gioi_Tinh,Ma_Phong,SDT,Dia_Chi,Email,Ngay_Lam,Ma_chuc_vu")] NHANVIEN nHANVIEN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nHANVIEN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Ma_chuc_vu = new SelectList(db.CHUCVUs, "Ma_CV", "Ten_CV", nHANVIEN.Ma_chuc_vu);
            ViewBag.Ma_Phong = new SelectList(db.PHONGBANs, "Ma_phong", "Ten_Phong", nHANVIEN.Ma_Phong);
            return View(nHANVIEN);
        }

        // GET: NHANVIENs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NHANVIEN nHANVIEN = db.NHANVIENs.Find(id);
            if (nHANVIEN == null)
            {
                return HttpNotFound();
            }
            return View(nHANVIEN);
        }

        // POST: NHANVIENs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NHANVIEN nHANVIEN = db.NHANVIENs.Find(id);
            db.NHANVIENs.Remove(nHANVIEN);
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
