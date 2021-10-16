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
    public class QLLopsController : Controller
    {
        private QLDiemHocSinhDbContext db = new QLDiemHocSinhDbContext();

        // GET: QLLops
        public ActionResult Index()
        {
            return View(db.Lops.ToList());
        }

        // GET: QLLops/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QLLop qLLop = db.Lops.Find(id);
            if (qLLop == null)
            {
                return HttpNotFound();
            }
            return View(qLLop);
        }

        // GET: QLLops/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QLLops/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLop,TenLop,NienKhoa,SiSo,GhiChu")] QLLop qLLop)
        {
            if (ModelState.IsValid)
            {
                db.Lops.Add(qLLop);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(qLLop);
        }

        // GET: QLLops/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QLLop qLLop = db.Lops.Find(id);
            if (qLLop == null)
            {
                return HttpNotFound();
            }
            return View(qLLop);
        }

        // POST: QLLops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLop,TenLop,NienKhoa,SiSo,GhiChu")] QLLop qLLop)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qLLop).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(qLLop);
        }

        // GET: QLLops/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QLLop qLLop = db.Lops.Find(id);
            if (qLLop == null)
            {
                return HttpNotFound();
            }
            return View(qLLop);
        }

        // POST: QLLops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            QLLop qLLop = db.Lops.Find(id);
            db.Lops.Remove(qLLop);
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