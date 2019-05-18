using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using QLVT.Models;

namespace QLVT.Controllers
{
    public class LichTausController : Controller
    {
        private QuanLyVeTauContextEntities db = new QuanLyVeTauContextEntities();

        // GET: LichTaus
        public ActionResult Index()
        {
            var lichTaus = db.LichTaus.Include(l => l.DSTau).Include(l => l.GaTau).Include(l => l.GaTau1);
            return View(lichTaus.ToList());
        }

        // GET: LichTaus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LichTau lichTau = db.LichTaus.Find(id);
            if (lichTau == null)
            {
                return HttpNotFound();
            }
            return View(lichTau);
        }

        // GET: LichTaus/Create
        public ActionResult Create()
        {
            ViewBag.MaTau = new SelectList(db.DSTaus, "MaDSTau", "TenTau");
            ViewBag.MaGaDen = new SelectList(db.GaTaus, "MaGaTau", "TenGa");
            ViewBag.MaGaDi = new SelectList(db.GaTaus, "MaGaTau", "TenGa");
            return View();
        }

        // POST: LichTaus/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLichTau,MaTau,MaGaDi,MaGaDen,NgayDi,ThoiGianDi,ThoiGianDen")] LichTau lichTau)
        {
            if (ModelState.IsValid)
            {
                db.LichTaus.Add(lichTau);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaTau = new SelectList(db.DSTaus, "MaDSTau", "TenTau", lichTau.MaTau);
            ViewBag.MaGaDen = new SelectList(db.GaTaus, "MaGaTau", "TenGa", lichTau.MaGaDen);
            ViewBag.MaGaDi = new SelectList(db.GaTaus, "MaGaTau", "TenGa", lichTau.MaGaDi);
            return View(lichTau);
        }

        // GET: LichTaus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LichTau lichTau = db.LichTaus.Find(id);
            if (lichTau == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaTau = new SelectList(db.DSTaus, "MaDSTau", "TenTau", lichTau.MaTau);
            ViewBag.MaGaDen = new SelectList(db.GaTaus, "MaGaTau", "TenGa", lichTau.MaGaDen);
            ViewBag.MaGaDi = new SelectList(db.GaTaus, "MaGaTau", "TenGa", lichTau.MaGaDi);
            return View(lichTau);
        }

        // POST: LichTaus/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLichTau,MaTau,MaGaDi,MaGaDen,NgayDi,ThoiGianDi,ThoiGianDen")] LichTau lichTau)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lichTau).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaTau = new SelectList(db.DSTaus, "MaDSTau", "TenTau", lichTau.MaTau);
            ViewBag.MaGaDen = new SelectList(db.GaTaus, "MaGaTau", "TenGa", lichTau.MaGaDen);
            ViewBag.MaGaDi = new SelectList(db.GaTaus, "MaGaTau", "TenGa", lichTau.MaGaDi);
            return View(lichTau);
        }

        // GET: LichTaus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LichTau lichTau = db.LichTaus.Find(id);
            if (lichTau == null)
            {
                return HttpNotFound();
            }
            return View(lichTau);
        }

        // POST: LichTaus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LichTau lichTau = db.LichTaus.Find(id);
            db.LichTaus.Remove(lichTau);
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
