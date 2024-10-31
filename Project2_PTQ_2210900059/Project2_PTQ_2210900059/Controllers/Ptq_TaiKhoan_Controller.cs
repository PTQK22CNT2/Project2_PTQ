using Project2_PTQ_2210900059.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2_PTQ_2210900059.Controllers
{
    public class Ptq_TaiKhoan_Controller : Controller
    {
        // GET: Ptq_TaiKhoan_/Index
        public ActionResult Danh_sach_tai_khoan()
        {
            var listtaikhoan = new Ptq_2210900059_Model().TAIKHOANs.ToList();
            return View(listtaikhoan);
        }

        // GET: Ptq_TaiKhoan_/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ptq_TaiKhoan_/Create
        [HttpPost]
        public ActionResult Create(TAIKHOAN taikhoan)
        {
            try
            {
                var context = new Ptq_2210900059_Model();
                context.TAIKHOANs.Add(taikhoan);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ptq_TaiKhoan_/Edit
        public ActionResult Edit(string Ma_TK)
        {
            var context = new Ptq_2210900059_Model();
            var editing = context.TAIKHOANs.Find(Ma_TK);
            return View(editing);
        }

        // POST: Ptq_TaiKhoan_/Edit
        [HttpPost]
        public ActionResult Edit(TAIKHOAN taikhoan)
        {
            try
            {
                var context = new Ptq_2210900059_Model();
                var oldItem = context.TAIKHOANs.Find(taikhoan.Ma_TK);
                oldItem.Ten_Dang_Nhap = taikhoan.Ten_Dang_Nhap;
                oldItem.Mat_Khau = taikhoan.Mat_Khau;
                oldItem.Ma_NV = taikhoan.Ma_NV;
                oldItem.Ma_VT = taikhoan.Ma_VT;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Ptq_TaiKhoan_/Delete
        public ActionResult Delete(string Ma_TK)
        {
            var context = new Ptq_2210900059_Model();
            var deleting = context.TAIKHOANs.Find(Ma_TK);
            return View(deleting);
        }

        // POST: Ptq_TaiKhoan_/Delete
        [HttpPost]
        public ActionResult Delete(string Ma_TK, TAIKHOAN taikhoan)
        {
            try
            {
                var context = new Ptq_2210900059_Model();
                var deleting = context.TAIKHOANs.Find(Ma_TK);
                context.TAIKHOANs.Remove(deleting);
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
