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
    public class TAIKHOANsController : Controller
    {
        private project2_PTQEntities1 db = new project2_PTQEntities1();

        // GET: TAIKHOANs
        public ActionResult Index()
        {
            var tAIKHOANs = db.TAIKHOANs.Include(t => t.NHANVIEN).Include(t => t.VAITRO_QUYEN);
            return View(tAIKHOANs.ToList());
        }

        // GET: TAIKHOANs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAIKHOAN tAIKHOAN = db.TAIKHOANs.Find(id);
            if (tAIKHOAN == null)
            {
                return HttpNotFound();
            }
            return View(tAIKHOAN);
        }

        // GET: TAIKHOANs/Create
        public ActionResult Create()
        {
            ViewBag.Ma_NV = new SelectList(db.NHANVIENs, "Ma_NV", "Ho_Ten");
            ViewBag.Ma_VT = new SelectList(db.VAITRO_QUYEN, "Ma_VT", "Ten_VT");
            return View();
        }

        // POST: TAIKHOANs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Ma_TK,Ten_Dang_Nhap,Mat_Khau,Ma_NV,Ma_VT")] TAIKHOAN tAIKHOAN)
        {
            if (ModelState.IsValid)
            {
                db.TAIKHOANs.Add(tAIKHOAN);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Ma_NV = new SelectList(db.NHANVIENs, "Ma_NV", "Ho_Ten", tAIKHOAN.Ma_NV);
            ViewBag.Ma_VT = new SelectList(db.VAITRO_QUYEN, "Ma_VT", "Ten_VT", tAIKHOAN.Ma_VT);
            return View(tAIKHOAN);
        }

        // GET: TAIKHOANs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAIKHOAN tAIKHOAN = db.TAIKHOANs.Find(id);
            if (tAIKHOAN == null)
            {
                return HttpNotFound();
            }
            ViewBag.Ma_NV = new SelectList(db.NHANVIENs, "Ma_NV", "Ho_Ten", tAIKHOAN.Ma_NV);
            ViewBag.Ma_VT = new SelectList(db.VAITRO_QUYEN, "Ma_VT", "Ten_VT", tAIKHOAN.Ma_VT);
            return View(tAIKHOAN);
        }

        // POST: TAIKHOANs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Ma_TK,Ten_Dang_Nhap,Mat_Khau,Ma_NV,Ma_VT")] TAIKHOAN tAIKHOAN)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tAIKHOAN).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Ma_NV = new SelectList(db.NHANVIENs, "Ma_NV", "Ho_Ten", tAIKHOAN.Ma_NV);
            ViewBag.Ma_VT = new SelectList(db.VAITRO_QUYEN, "Ma_VT", "Ten_VT", tAIKHOAN.Ma_VT);
            return View(tAIKHOAN);
        }

        // GET: TAIKHOANs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TAIKHOAN tAIKHOAN = db.TAIKHOANs.Find(id);
            if (tAIKHOAN == null)
            {
                return HttpNotFound();
            }
            return View(tAIKHOAN);
        }

        // POST: TAIKHOANs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TAIKHOAN tAIKHOAN = db.TAIKHOANs.Find(id);
            db.TAIKHOANs.Remove(tAIKHOAN);
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
