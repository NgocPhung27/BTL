using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLDiemHocSinh.Models;

namespace QLDiemHocSinh.Controllers
{
    public class QLGiaoViensController : Controller
    {
        private QLDiemHocSinhDbContext db = new QLDiemHocSinhDbContext();

        AutoGenerateKey aukey = new AutoGenerateKey();

        // GET: QLHocSinhs
        public ActionResult Index()
        {
            return View(db.GiaoViens.ToList());
        }
        public ActionResult Create()
        {
            var gvID = "";
            var countGV = db.GiaoViens.Count();
            if (countGV == 0)
            {
                gvID = "GV001";
            }
            else
            {
                //Lấy giá trị MaHS moi nhat
                var MaGV = db.GiaoViens.ToList().OrderByDescending(m => m.MaGV).FirstOrDefault().MaGV;
                //sinh MaHS tự dộng
                gvID = aukey.GenerateKey(MaGV);
            }
            ViewBag.MaGV = gvID;
            return View();
        }
        [HttpPost]
        public ActionResult Create(QLGiaoVien gv)

        {
            var countGV = db.GiaoViens.Count();
            if (countGV == 0)
            {
                gv.MaGV = "GV001";
            }
            else
            {
                //Lấy giá trị MaHS moi nhat
                var MaGV = db.GiaoViens.ToList().OrderByDescending(m => m.MaGV).FirstOrDefault().MaGV;
                //sinh MaHS tự dộng
                gv.MaGV = aukey.GenerateKey(MaGV);
            }
            //luu thông tin vao database
            db.GiaoViens.Add( gv );
            db.SaveChanges();

            return RedirectToAction("Index");
        }
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

        // GET: QLGiaoViens/Edit/5
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

        // POST: QLGiaoViens/Edit/5
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

        // GET: QLGiaoViens/Delete/5
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

        // POST: QLGiaoViens/Delete/5
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
