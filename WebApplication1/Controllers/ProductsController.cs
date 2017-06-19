using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Bus;
using WebApplication1.Models.ViewModel;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products

        public ActionResult Index(int Page = 1)
        {
            var DsSanPham = SanPhamBus.PageDanhSach(Page, 8);
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

        // GET: SanPham/Details/5
        public ActionResult Details(int id)
        {
            var BinhLuan = BinhLuanBUS.DanhSach(id);
            var ChiTietSP = SanPhamBus.ChiTiet(id);
            var ChiTietLoaiSP = LoaiBus.ChiTietViewModel(ChiTietSP.MaLoai);
            var ChitTietHangSP = HangBus.ChiTietViewModel(ChiTietSP.MaHang);
            if (User.Identity.IsAuthenticated)
            {
                int SoLuongGioHang = GioHangBus.SoLuong(User.Identity.GetUserId());
                ViewBag.SoLuong = SoLuongGioHang;
            }
            else
            {
                ViewBag.SoLuong = 0;
            }
            return View(new SanPhamViewModel() {LoaiSP=ChiTietLoaiSP,HangSP=ChitTietHangSP,SanPham=ChiTietSP,BinhLuanSP=BinhLuan });
        }
        public ActionResult Type(int id,int Page = 1)
        {
            var dsSanPham = SanPhamBus.PageDanhSachTheoLoaiSP(Page, 8, id);
            return View(dsSanPham);
        }
        public ActionResult Producer(int id,int Page = 1)
        {
            var dsSanPham = SanPhamBus.PageDanhSachTheoNSX(Page, 8, id);
            return View(dsSanPham);
        }

        [HttpGet]
        public ActionResult Search(string keyword, int Page = 1)
        {
            var DanhSachTimKiem = SanPhamBus.DanhSachTimKiem(Page, 8, keyword);
            return View(DanhSachTimKiem);
        }

        [HttpGet]
        public ActionResult SearchNC(string tensp, string loaisp, string hangsp, string chitietsp, int Page = 1)
        {
            var DanhSachTimKiemNC = SanPhamBus.DanhSachTimKiemNC(Page, 8, tensp, loaisp, hangsp, chitietsp);
            return View(DanhSachTimKiemNC);
        }
    }
}