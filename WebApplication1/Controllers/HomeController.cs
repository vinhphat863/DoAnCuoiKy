using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Bus;
namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var DsSanPham = SanPhamBus.DanhSach();
            if (User.Identity.IsAuthenticated)
            {
                int SoLuongGioHang = GioHangBus.SoLuong(User.Identity.GetUserId());
                ViewBag.SoLuong = SoLuongGioHang;
            }
            else
            {
                ViewBag.SoLuong = 0;
            }
            return View(DsSanPham);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Cart()
        {
            return View();
        }
    }
}