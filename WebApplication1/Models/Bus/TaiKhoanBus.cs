using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MobileShopConnection;
using PetaPoco;

namespace WebApplication1.Models.Bus
{
    public class TaiKhoanBus
    {
        public static Page<MobileShopConnection.AspNetUser> PageDanhSach(int PageNumber,int ItemPerPage)
        {
            var db = new MobileShopConnectionDB();
            return db.Page<AspNetUser>(PageNumber,ItemPerPage,"select * from AspNetUsers where IsLocked = 'False'");
        }
        public static Page<MobileShopConnection.AspNetUser> PageDanhSachDaKhoa(int PageNumber, int ItemPerPage)
        {
            var db = new MobileShopConnectionDB();
            return db.Page<AspNetUser>(PageNumber, ItemPerPage, "select * from AspNetUsers where IsLocked = 'True'");
        }
        public static AspNetUser LayChiTiet(string MaTaiKhoan)
        {
            var db = new MobileShopConnectionDB();
            return db.FirstOrDefault<AspNetUser>("select * from AspNetUsers where Id=@0", MaTaiKhoan);
        }
        public static void Xoa(string MaTaiKhoan)
        {
            var db = new MobileShopConnectionDB();
            db.Execute("Update AspNetUsers set IsLocked='True' where Id=@0", MaTaiKhoan);
        }
        public static void KhoiPhuc(string MaTaiKhoan)
        {
            var db = new MobileShopConnectionDB();
            db.Execute("Update AspNetUsers set IsLocked='False' where Id=@0", MaTaiKhoan);
        }
        public static void Sua(AspNetUser a)
        {
            var db = new MobileShopConnectionDB();
            db.Update(a);
        }
    }
}