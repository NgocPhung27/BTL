using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLDiemHocSinh.Areas.Admins
{
    [Authorize(Roles = "Admin")]
    public class HomeAdminController : Controller
    {
        // GET: Admins/HomeAdmin
        public ActionResult Index()
        {
            return View();
        }
    }
}