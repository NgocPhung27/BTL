using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLDiemHocSinh.Areas.GVClient.Controllers
{
    [Authorize(Roles = "GV")]
    public class HomeGVController : Controller
    {
        // GET: GVClient/HomeGV
        public ActionResult Index()
        {
            return View();
        }
    }
}