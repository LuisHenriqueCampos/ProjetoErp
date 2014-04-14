using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_ANDERSON.Models;

namespace ERP_ANDERSON.Controllers
{
    public class CargoController : Controller
    {
        private ERPContext db = new ERPContext();

        //
        // GET: /Cargo/

        public ActionResult Index()
        {
            return View(db.Cargos.ToList());
        }

        //
        // GET: /Cargo/Details/5

        public ActionResult Details(int id = 0)
        {
            Cargo cargo = db.Cargos.Find(id);
            if (cargo == null)
            {
                return HttpNotFound();
            }
            return View(cargo);
        }

        //
        // GET: /Cargo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Cargo/Create

        [HttpPost]
        public ActionResult Create(Cargo cargo)
        {
            if (ModelState.IsValid)
            {
                db.Cargos.Add(cargo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cargo);
        }

        //
        // GET: /Cargo/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Cargo cargo = db.Cargos.Find(id);
            if (cargo == null)
            {
                return HttpNotFound();
            }
            return View(cargo);
        }

        //
        // POST: /Cargo/Edit/5

        [HttpPost]
        public ActionResult Edit(Cargo cargo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cargo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cargo);
        }

        //
        // GET: /Cargo/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Cargo cargo = db.Cargos.Find(id);
            if (cargo == null)
            {
                return HttpNotFound();
            }
            return View(cargo);
        }

        //
        // POST: /Cargo/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Cargo cargo = db.Cargos.Find(id);
            db.Cargos.Remove(cargo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}