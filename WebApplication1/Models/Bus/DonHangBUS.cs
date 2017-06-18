using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MobileShopConnection;
namespace WebApplication1.Models.Bus
{
    public class DonHangBUS
    {
        public static IEnumerable<DonHang> DanhSach(string MaTaiKhoan)
        {
            var db = new MobileShopConnectionDB();
            return db.Query<DonHang>("Select * from DonHang where MaTK = @0", MaTaiKhoan);
        }
        public static IEnumerable<v_ChiTietDonHang> LayChiTiet(int MaDonHang)
        {
            var db = new MobileShopConnectionDB();
            return db.Query<v_ChiTietDonHang>("Select * from v_ChiTietDonHang where MaDonHang=@0", MaDonHang);
        }
    }
}