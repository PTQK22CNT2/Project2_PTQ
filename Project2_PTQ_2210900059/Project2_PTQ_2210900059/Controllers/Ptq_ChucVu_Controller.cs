using Project2_PTQ_2210900059.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2_PTQ_2210900059.Controllers
{
    public class Ptq_ChucVu_Controller : Controller
    {
        // GET: Ptq_ChucVu_/Index
        public ActionResult Danh_sach_chuc_vu()
        {
            var listchucvu = new Ptq_2210900059_Model().CHUCVUs.ToList();
            return View(listchucvu);
        }

        // GET: Ptq_ChucVu_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ptq_ChucVu_/Create
        [HttpPost]
        public ActionResult Create(CHUCVU chucvu)
        {
            try
            {
                var context = new Ptq_2210900059_Model();
                context.CHUCVUs.Add(chucvu);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ptq_ChucVu_/Edit
        public ActionResult Edit(string Ma_CV)
        {
            var context = new Ptq_2210900059_Model();
            var editing = context.CHUCVUs.Find(Ma_CV);
            return View(editing);
        }

        // POST: Ptq_ChucVu_/Edit
        [HttpPost]
        public ActionResult Edit(CHUCVU chucvu)
        {
            try
            {
                var context = new Ptq_2210900059_Model();
                var oldItem = context.CHUCVUs.Find(chucvu.Ma_CV);
                oldItem.Ten_CV = chucvu.Ten_CV;
                oldItem.Luong_CB = chucvu.Luong_CB;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ptq_ChucVu_/Delete
        public ActionResult Delete(string Ma_CV)
        {
            var context = new Ptq_2210900059_Model();
            var deleting = context.CHUCVUs.Find(Ma_CV);
            return View(deleting);
        }

        // POST: Ptq_ChucVu_/Delete
        [HttpPost]
        public ActionResult Delete(string Ma_CV, CHUCVU chucvu)
        {
            try
            {
                var context = new Ptq_2210900059_Model();
                var deleting = context.CHUCVUs.Find(Ma_CV);
                context.CHUCVUs.Remove(deleting);
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
