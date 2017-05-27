using Microsoft.AspNet.Identity;
using MobileShopConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models.Bus;

namespace WebApplication1.Controllers
{
    public class BinhLuanAPIController : ApiController
    {
        // GET: api/BinhLuanAPI
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/BinhLuanAPI/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/BinhLuanAPI
        public void Post([FromBody]BinhLuan bl)
        {
            bl.MaTaiKhoan = User.Identity.GetUserId();
            bl.TinhTrang = 0;
            bl.ThoiGian = DateTime.Now;
            bl.TenTaiKhoan = User.Identity.Name;
            BinhLuanBUS.ThemBinhLuan(bl);
        }

        // PUT: api/BinhLuanAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/BinhLuanAPI/5
        public void Delete(int id)
        {
        }
    }
}
