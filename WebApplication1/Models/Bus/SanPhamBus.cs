using MobileShopConnection;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Models.Bus
{
    public class SanPhamBus
    {
        public static IEnumerable<MobileShopConnection.SanPham> DanhSach()
        {
            var db = new MobileShopConnectionDB();
            return db.Query<MobileShopConnection.SanPham>("select * from SanPham where BiXoa != 1");
        }
        public static IEnumerable<SanPham> DanhSachSPCungNhaSanXuat(int MaHang,int MaSP)
        {
            var db = new MobileShopConnectionDB();
            return db.Query<SanPham>("select top 5 * from SanPham where MaHang=@0 and MaSP != @1 and BiXoa != 1",MaHang,MaSP);
        }
        public static Page<SanPham> PageDanhSachDaXoa(int PageNumber, int ItemPerPage)
        {
            var db = new MobileShopConnectionDB();
            return db.Page<SanPham>(PageNumber, ItemPerPage, "select * from SanPham where BiXoa = 1");
        }
        public static Page<SanPham> PageDanhSachTheoLoaiSP(int PageNumber,int ItemPerPage, int id)
        {
            var db = new MobileShopConnectionDB();
            return db.Page<SanPham>(PageNumber, ItemPerPage, "select * from SanPham where MaLoai=@0 and BiXoa != 1",id);
        }

        public static Page<SanPham> PageDanhSachTheoNSX(int PageNumber,int ItemPerPage, int id)
        {
            var db = new MobileShopConnectionDB();
            return db.Page<SanPham>(PageNumber, ItemPerPage, "select * from SanPham where MaHang=@0 and BiXoa != 1", id);
        }

        public static Page<SanPham> PageDanhSach(int PageNumber, int ItemPerPage)
        {
            var db = new MobileShopConnectionDB();
            return db.Page<SanPham>(PageNumber, ItemPerPage, "select * from SanPham where BiXoa != 1");
        }
        public static MobileShopConnection.SanPham ChiTiet(int id)
        {
            var db = new MobileShopConnectionDB();
            return db.SingleOrDefault<MobileShopConnection.SanPham>("select * from sanpham where MaSP=@0", id);
        }
        public static void Them(MobileShopConnection.SanPham sp)
        {
            var db = new MobileShopConnectionDB();
            db.Insert(sp);
        }
        public static void Xoa(int id)
        {
            var db = new MobileShopConnectionDB();
            var rs = Sql.Builder.Append("Exec XoaSanPham @0", id);
            db.Execute(rs);
        }
        public static void Sua(MobileShopConnection.SanPham sp)
        {
            var db = new MobileShopConnectionDB();
            db.Update(sp);
        }

        public static void KhoiPhuc(int id)
        {
            var db = new MobileShopConnectionDB();
            var rs = Sql.Builder.Append("Exec KhoiPhucSanPham @0", id);
            db.Execute(rs);
        }

        public static Page<SanPham> DanhSachTimKiem(int PageNumber, int ItemPerPage, string keyword)
        {
            var db = new MobileShopConnectionDB();
            return db.Page<SanPham>(PageNumber, ItemPerPage, "select * from SanPham where TenSP like @0", "%"+keyword+"%");
        }

        public static Page<SanPham> DanhSachTimKiemNC(int PageNumber, int ItemPerPage, string tensp, string loaisp, string hangsp, string chitietsp)
        {
            var db = new MobileShopConnectionDB();
            return db.Page<SanPham>(PageNumber, ItemPerPage,
                "select sp.MaSP, sp.TenSP, sp.MaHang, sp.MaLoai, sp.HinhAnh, sp.TinhTrang, sp.GiaBan, sp.SoLuong, sp.BiXoa, sp.ChiTiet from SanPham sp, LoaiSP l, HangSP h where sp.MaLoai=l.MaLoai and sp.MaHang=h.MaHang and sp.TenSP like @0 and l.TenLoai like @1 and h.TenHang like @2 and sp.ChiTiet like @3",
                "%" + tensp + "%", "%" + loaisp + "%", "%" + hangsp + "%", "%" + chitietsp + "%");
        }
    }
}