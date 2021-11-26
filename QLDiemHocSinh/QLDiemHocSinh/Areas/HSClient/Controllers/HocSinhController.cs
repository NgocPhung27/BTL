using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLDiemHocSinh.Areas.HSClient.Controllers
{
    [Authorize (Roles ="HS")]
    public class HocSinhController : Controller
    {
        // GET: HSClient/HocSinh
        public ActionResult Index()
        {
            return View();
        }
    }
}