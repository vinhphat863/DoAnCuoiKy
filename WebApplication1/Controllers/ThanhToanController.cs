using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using WebApplication1.Models.Bus;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class ThanhToanController : Controller
    {
        // GET: ThanhToan
        public ActionResult Index()
        {
            var rs = DonHangBUS.DanhSach(User.Identity.GetUserId());
            return View(rs);
        }
    }
}