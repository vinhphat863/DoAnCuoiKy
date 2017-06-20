using MobileShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Bus;

namespace WebApplication1.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class QuanLyDonHangController : Controller
    {
        // GET: Admin/QuanLyDonHang
        public ActionResult Index(int Page=1)
        {
            var rs = DonHangBUS.PageDanhSachDonHang(Page,10);
            return View(rs);
        }

        // GET: Admin/QuanLyDonHang/Details/5
        public ActionResult Details(int id)
        {
            var rs = DonHangBUS.LayChiTiet(id);
            return View(rs);
        }

        // GET: Admin/QuanLyDonHang/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/QuanLyDonHang/Create
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

        // GET: Admin/QuanLyDonHang/Edit/5
        public ActionResult Edit(int id)
        {
            var rs = DonHangBUS.LayThongTinDonHang(id);
            ViewBag.MaTinhTrang = new SelectList(DonHangBUS.LayDanhSachTinhTrang(), "MaTinhTrang", "TenTinhTrang",rs.MaTinhTrang);
            return View(rs);
        }

        // POST: Admin/QuanLyDonHang/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, DonHang d)
        {
            try
            {
                // TODO: Add update logic here
                DonHangBUS.Update(d);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/QuanLyDonHang/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/QuanLyDonHang/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
