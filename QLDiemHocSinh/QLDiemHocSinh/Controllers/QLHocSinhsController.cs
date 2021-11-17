﻿using System;
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
    public class QLHocSinhsController : Controller
    {
        private QLDiemHocSinhDbContext db = new QLDiemHocSinhDbContext();
        AutoGenerateKey aukey = new AutoGenerateKey();

        // GET: QLHocSinhs
        public ActionResult Index()
        {
            return View(db.HocSinhs.ToList());
        }
        public ActionResult Create()
        {
            var hsID = "";
            var countHS = db.HocSinhs.Count();
            if (countHS == 0)
            {
                hsID ="HS001";
            }
            else
            {
                //Lấy giá trị MaHS moi nhat
                var MaHS = db.HocSinhs.ToList().OrderByDescending(m => m.MaHS).FirstOrDefault().MaHS;
                //sinh MaHS tự dộng
                hsID = aukey.GenerateKey(MaHS);
            }
            ViewBag.MaHS = hsID;
            return View();
        }
        [HttpPost]
        public ActionResult Create(QLHocSinh hs)

        {
            var countHS = db.HocSinhs.Count();
            if (countHS == 0)
            {
                hs.MaHS ="HS001";
            }
            else
            {
                //Lấy giá trị MaHS moi nhat
                var MaHS = db.HocSinhs.ToList().OrderByDescending(m => m.MaHS).FirstOrDefault().MaHS;
                //sinh MaHS tự dộng
                hs.MaHS = aukey.GenerateKey(MaHS);
            }
            //luu thông tin vao database
            db.HocSinhs.Add(hs);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: QLHocSinhs/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QLHocSinh qLHocSinh = db.HocSinhs.Find(id);
            if (qLHocSinh == null)
            {
                return HttpNotFound();
            }
            return View(qLHocSinh);
        }

        // GET: QLHocSinhs/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QLHocSinh qLHocSinh = db.HocSinhs.Find(id);
            if (qLHocSinh == null)
            {
                return HttpNotFound();
            }
            return View(qLHocSinh);
        }

        // POST: QLHocSinhs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaHS,TenHS,GioiTinh,NgaySinh,SoDienThoai,DiaChi,Lop,AnhHS")] QLHocSinh qLHocSinh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qLHocSinh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(qLHocSinh);
        }

        // GET: QLHocSinhs/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QLHocSinh qLHocSinh = db.HocSinhs.Find(id);
            if (qLHocSinh == null)
            {
                return HttpNotFound();
            }
            return View(qLHocSinh);
        }

        // POST: QLHocSinhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            QLHocSinh qLHocSinh = db.HocSinhs.Find(id);
            db.HocSinhs.Remove(qLHocSinh);
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
