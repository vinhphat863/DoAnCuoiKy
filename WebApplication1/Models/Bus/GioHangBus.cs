using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MobileShopConnection;
using PetaPoco;

namespace WebApplication1.Models.Bus
{
    public class GioHangBus
    {
        public static IEnumerable<MobileShopConnection.v_GioHang> DanhSach(string MaTaiKhoan)
        {
            using (var db = new MobileShopConnectionDB())
            {
                return db.Query<v_GioHang>("select * from v_GioHang where MaTaiKhoan=@0 and DaThanhToan = 0", MaTaiKhoan);
            }
        }
        public static int SoLuong(string MaTaiKhoan)
        {
            using(var db = new MobileShopConnectionDB())
            {
                return db.Query<v_GioHang>("select * from v_GioHang where MaTaiKhoan=@0 and DaThanhToan = 0", MaTaiKhoan).Count();
            }
        }
        public static void Them(int MaSanPham,string MaTaiKhoan)
        {
            using(var db =new MobileShopConnectionDB())
            {
                var rs = Sql.Builder.Append("Exec ThemGioHang @0,@1", MaSanPham,MaTaiKhoan);
                db.Execute(rs);
            }
        }

        public static void CapNhat(int idGioHang,int SoLuong,int MaSanPham,string MaTaiKhoan)
        {
            using (var db = new MobileShopConnectionDB()) {
                if(SoLuong != 0)
                {
                    db.Execute("Update GioHang set SoLuong=@0 where MaSanPham=@1 and MaTaiKhoan=@2 and DaThanhToan = 0", SoLuong, MaSanPham, MaTaiKhoan);
                }
                else
                {
                    Xoa(idGioHang,MaSanPham, MaTaiKhoan);
                }
            }
        }
        public static void Xoa(int idGioHang,int MaSanPham,string MaTaiKhoan)
        {
            using(var db = new MobileShopConnectionDB())
            {
                GioHang gh = new GioHang()
                {
                    id = idGioHang,
                    MaSanPham = MaSanPham,
                    MaTaiKhoan = MaTaiKhoan,
                    DaThanhToan = 0
                };
                db.Delete<GioHang>(gh);
            }
        }

        public static void ThanhToan(string MaTaiKhoan)
        {
            using(var db = new MobileShopConnectionDB())
            {
                var rs = Sql.Builder.Append("Exec ThanhToan @0", MaTaiKhoan);
                db.Execute(rs);
            }
        }
    }
}