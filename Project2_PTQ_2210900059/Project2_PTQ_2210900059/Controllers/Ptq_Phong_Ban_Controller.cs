using Project2_PTQ_2210900059.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2_PTQ_2210900059.Controllers
{
    public class Ptq_Phong_Ban_Controller : Controller
    {
        // GET: PhongBan
        public ActionResult Danh_sach_phong_ban()
        {
            var context = new Ptq_2210900059_Model();
            var listPhongBan = context.PHONGBANs.ToList();
            return View(listPhongBan);
        }

        // GET: PhongBan/Details
        public ActionResult Details(string Ma_phong)
        {
            var context = new Ptq_2210900059_Model();
            var phongBan = context.PHONGBANs.Find(Ma_phong);
            return View(phongBan);
        }

        // GET: PhongBan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PhongBan/Create
        [HttpPost]
        public ActionResult Create(PHONGBAN phongBan)
        {
            try
            {
                var context = new Ptq_2210900059_Model();
                context.PHONGBANs.Add(phongBan);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PhongBan/Edit/5
        public ActionResult Edit(string Ma_phong)
        {
            var context = new Ptq_2210900059_Model();
            var phongBan = context.PHONGBANs.Find(Ma_phong);
            return View(phongBan);
        }

        // POST: PhongBan/Edit
        [HttpPost]
        public ActionResult Edit(PHONGBAN phongBan)
        {
            try
            {
                var context = new Ptq_2210900059_Model();
                var oldPhongBan = context.PHONGBANs.Find(phongBan.Ma_phong);
                oldPhongBan.Ten_Phong = phongBan.Ten_Phong;
                oldPhongBan.Ma_QL = phongBan.Ma_QL;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: PhongBan/Delete
        public ActionResult Delete(string Ma_phong)
        {
            var context = new Ptq_2210900059_Model();
            var phongBan = context.PHONGBANs.Find(Ma_phong);
            return View(phongBan);
        }

        // POST: PhongBan/Delete
        [HttpPost]
        public ActionResult Delete(string Ma_phong, PHONGBAN phongBan)
        {
            try
            {
                var context = new Ptq_2210900059_Model();
                var deletingPhongBan = context.PHONGBANs.Find(Ma_phong);
                context.PHONGBANs.Remove(deletingPhongBan);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}