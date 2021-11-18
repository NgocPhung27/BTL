using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLDiemHocSinh.Models;

namespace QLDiemHocSinh.Areas.GVClient.Controllers
{
    [Authorize(Roles = "GV")]
    public class QLGiaoViensClientController : Controller
    {
        private QLDiemHocSinhDbContext db = new QLDiemHocSinhDbContext();

        // GET: GVClient/QLGiaoViensClient
        public ActionResult Index()
        {
            return View(db.GiaoViens.ToList());
        }

        // GET: GVClient/QLGiaoViensClient/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QLGiaoVien qLGiaoVien = db.GiaoViens.Find(id);
            if (qLGiaoVien == null)
            {
                return HttpNotFound();
            }
            return View(qLGiaoVien);
        }

        // GET: GVClient/QLGiaoViensClient/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GVClient/QLGiaoViensClient/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaGV,TenGV,GioiTinh,NgaySinh,SoDienThoai,DiaChi,Lop,AnhGV")] QLGiaoVien qLGiaoVien)
        {
            if (ModelState.IsValid)
            {
                db.GiaoViens.Add(qLGiaoVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(qLGiaoVien);
        }

        // GET: GVClient/QLGiaoViensClient/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QLGiaoVien qLGiaoVien = db.GiaoViens.Find(id);
            if (qLGiaoVien == null)
            {
                return HttpNotFound();
            }
            return View(qLGiaoVien);
        }

        // POST: GVClient/QLGiaoViensClient/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaGV,TenGV,GioiTinh,NgaySinh,SoDienThoai,DiaChi,Lop,AnhGV")] QLGiaoVien qLGiaoVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qLGiaoVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(qLGiaoVien);
        }

        // GET: GVClient/QLGiaoViensClient/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QLGiaoVien qLGiaoVien = db.GiaoViens.Find(id);
            if (qLGiaoVien == null)
            {
                return HttpNotFound();
            }
            return View(qLGiaoVien);
        }

        // POST: GVClient/QLGiaoViensClient/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            QLGiaoVien qLGiaoVien = db.GiaoViens.Find(id);
            db.GiaoViens.Remove(qLGiaoVien);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
