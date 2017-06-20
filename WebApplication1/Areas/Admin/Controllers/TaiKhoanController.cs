using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileShopConnection;
using WebApplication1.Models.Bus;

namespace WebApplication1.Areas.Admin.Controllers
{
    [Authorize(Roles ="Admin")]
    public class TaiKhoanController : Controller
    {
        // GET: Admin/TaiKhoan
        public ActionResult Index(int Page = 1)
        {
            var rs = TaiKhoanBus.PageDanhSach(Page,10);
            return View(rs);
        }

        // GET: Admin/TaiKhoan/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/TaiKhoan/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/TaiKhoan/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/TaiKhoan/Edit/5
        public ActionResult Edit(string id)
        {
            var rs = TaiKhoanBus.LayChiTiet(id);
            return View(rs);
        }

        // POST: Admin/TaiKhoan/Edit/5
        [HttpPost]
        public ActionResult Edit(string id, AspNetUser a)
        {
            try
            {
                // TODO: Add update logic here
                TaiKhoanBus.Sua(a);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Deleted(int Page = 1)
        {
            var rs = TaiKhoanBus.PageDanhSachDaKhoa(Page, 10);
            return View(rs);
        }

        public ActionResult Restore(string id)
        {
            var rs = TaiKhoanBus.LayChiTiet(id);
            return View(rs);
        }
        [HttpPost]
        public ActionResult Restore(string id, FormCollection collection)
        {
            TaiKhoanBus.KhoiPhuc(id);
            return RedirectToAction("Deleted");
        }
        // GET: Admin/TaiKhoan/Delete/5
        public ActionResult Delete(string id)
        {
            var rs = TaiKhoanBus.LayChiTiet(id);
            return View(rs);
        }

        // POST: Admin/TaiKhoan/Delete/5
        [HttpPost]
        public ActionResult Delete(string id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                TaiKhoanBus.Xoa(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
