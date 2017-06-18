using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MobileShopConnection;
using PetaPoco;

namespace WebApplication1.Models.Bus
{
    public class DonHangBUS
    {
        public static IEnumerable<v_DonHang> DanhSach(string MaTaiKhoan)
        {
            var db = new MobileShopConnectionDB();
            return db.Query<v_DonHang>("Select * from v_DonHang where MaTK = @0", MaTaiKhoan);
        }
        public static Page<v_DonHang> PageDanhSachDonHang(int PageNumber, int ItemPerPage)
        {
            var db = new MobileShopConnectionDB();
            return db.Page<v_DonHang>(PageNumber,ItemPerPage,"Select * from v_DonHang where BiXoa!=1");
        }
        
        public static IEnumerable<v_ChiTietDonHang> LayChiTiet(int MaDonHang)
        {
            var db = new MobileShopConnectionDB();
            return db.Query<v_ChiTietDonHang>("Select * from v_ChiTietDonHang where MaDonHang=@0", MaDonHang);
        }
        public static IEnumerable<TinhTrangDH> LayDanhSachTinhTrang()
        {
            var db = new MobileShopConnectionDB();
            return db.Query<TinhTrangDH>("select * from TinhTrangDH");
        }
        public static void Update(DonHang d)
        {
            var db = new MobileShopConnectionDB();
            db.Update(d);
        }
        public static DonHang LayThongTinDonHang(int MaDonHang)
        {
            var db = new MobileShopConnectionDB();
            return db.SingleOrDefault<DonHang>("select * from DonHang where MaDonHang=@0", MaDonHang);
        }
        
    }
}