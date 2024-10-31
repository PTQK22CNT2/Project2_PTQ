using Project2_PTQ_2210900059.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2_PTQ_2210900059.Controllers
{
    public class Ptq_VaiTroQuyen_Controller : Controller
    {
        // GET: Ptq_VaiTroQuyen_/Index
        public ActionResult Vaitro_Quyen()
        {
            var listVaiTroQuyen = new Ptq_2210900059_Model().VAITRO_QUYEN.ToList();
            return View(listVaiTroQuyen);
        }

        // GET: Ptq_VaiTroQuyen_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ptq_VaiTroQuyen_/Create
        [HttpPost]
        public ActionResult Create(VAITRO_QUYEN vaitroQuyen)
        {
            try
            {
                var context = new Ptq_2210900059_Model();
                context.VAITRO_QUYEN.Add(vaitroQuyen);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ptq_VaiTroQuyen_/Edit
        public ActionResult Edit(string Ma_VT)
        {
            var context = new Ptq_2210900059_Model();
            var editing = context.VAITRO_QUYEN.Find(Ma_VT);
            return View(editing);
        }

        // POST: Ptq_VaiTroQuyen_/Edit
        [HttpPost]
        public ActionResult Edit(VAITRO_QUYEN vaitroQuyen)
        {
            try
            {
                var context = new Ptq_2210900059_Model();
                var oldItem = context.VAITRO_QUYEN.Find(vaitroQuyen.Ma_VT);
                oldItem.Ten_VT = vaitroQuyen.Ten_VT;
                oldItem.Ma_Quyen = vaitroQuyen.Ma_Quyen;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ptq_VaiTroQuyen_/Delete
        public ActionResult Delete(string Ma_VT)
        {
            var context = new Ptq_2210900059_Model();
            var deleting = context.VAITRO_QUYEN.Find(Ma_VT);
            return View(deleting);
        }

        // POST: Ptq_VaiTroQuyen_/Delete
        [HttpPost]
        public ActionResult Delete(string Ma_VT, VAITRO_QUYEN vaitroQuyen)
        {
            try
            {
                var context = new Ptq_2210900059_Model();
                var deleting = context.VAITRO_QUYEN.Find(Ma_VT);
                context.VAITRO_QUYEN.Remove(deleting);
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
