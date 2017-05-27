using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MobileShopConnection;
namespace WebApplication1.Models.Bus
{
    public class BinhLuanBUS
    {
        public static void ThemBinhLuan(BinhLuan bl)
        {
            var db = new MobileShopConnectionDB();
            db.Insert(bl);
        }
        public static IEnumerable<BinhLuan> DanhSach(int id)
        {
            var db = new MobileShopConnectionDB();
            return db.Query<BinhLuan>("select * from BinhLuan where TinhTrang != 1 and MaSanPham=@0 order by ThoiGian desc",id);
        }
    }
}