using Project2_PTQ_2210900059.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2_PTQ_2210900059.Controllers
{
    public class Ptq_NhanVien_Controller : Controller
    {
        // GET: Ptq_NhanVien_
        public ActionResult Danh_sach_nhan_vien()
        {
            var listnhanvien = new Ptq_2210900059_Model().NHANVIENs.ToList();
            return View(listnhanvien);
        }
        // GET: Ptq_NhanVien/Details
        public ActionResult Details(string Ma_NV)
        {
            var context = new Ptq_2210900059_Model();
            var nhanVien = context.NHANVIENs.Find(Ma_NV);
            return View(nhanVien);
        }


        // GET: Ptq_NhanVien_/create
        public ActionResult Create()
        {
           
            return View();
        }
        //POST: Ptq_NhanVien_/create
        [HttpPost]
        
        public ActionResult Create(NHANVIEN nhanvien)
        {
            try
            { 
                var context = new Ptq_2210900059_Model();
                context.NHANVIENs.Add(nhanvien);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch 
            {
                return View();
            }
        }
        // GET: Ptq_NhanVien_/Edit
        public ActionResult Edit(int Ma_NV)
        {
            var context = new Ptq_2210900059_Model();
            var editing = context.NHANVIENs.Find(Ma_NV);
            return View(editing);
        }
        //POST: Ptq_NhanVien_/Edit
        [HttpPost]
        public ActionResult Edit(NHANVIEN nhanvien)
        {
            try
            {
                var context = new Ptq_2210900059_Model();
                var oldItem = context.NHANVIENs.Find(nhanvien.Ma_NV);
                oldItem.Ho_Ten = nhanvien.Ho_Ten;
                oldItem.Ngay_Sinh = nhanvien.Ngay_Sinh;
                oldItem.Gioi_Tinh = nhanvien.Gioi_Tinh;
                oldItem.Ma_Phong = nhanvien.Ma_Phong;
                oldItem.SDT = nhanvien.SDT;
                oldItem.Dia_Chi = nhanvien.Dia_Chi;
                oldItem.Email = nhanvien.Email;
                oldItem.Ngay_Lam = nhanvien.Ngay_Lam;
                oldItem.Ma_chuc_vu = nhanvien.Ma_chuc_vu;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: Ptq_NhanVien_/Delete
        public ActionResult Delete(int Ma_NV)
        {
            var context = new Ptq_2210900059_Model();
            var deleting = context.NHANVIENs.Find(Ma_NV);
            return View(deleting);
        }
        [HttpPost]
        public ActionResult Delete(int Ma_NV,NHANVIEN nhanvien)
        {
            try
            {
                var context = new Ptq_2210900059_Model();
                var deleting = context.NHANVIENs.Find(Ma_NV);
                context.NHANVIENs.Remove(deleting);
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