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
    public class EstadoController : Controller
    {
        private ERPContext db = new ERPContext();

        //
        // GET: /Estado/

        public ActionResult Index()
        {
            return View(db.Estados.ToList());
        }

        //
        // GET: /Estado/Details/5

        public ActionResult Details(int id = 0)
        {
            Estado estado = db.Estados.Find(id);
            if (estado == null)
            {
                return HttpNotFound();
            }
            return View(estado);
        }

        //
        // GET: /Estado/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Estado/Create

        [HttpPost]
        public ActionResult Create(Estado estado)
        {
            if (ModelState.IsValid)
            {
                db.Estados.Add(estado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estado);
        }

        //
        // GET: /Estado/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Estado estado = db.Estados.Find(id);
            if (estado == null)
            {
                return HttpNotFound();
            }
            return View(estado);
        }

        //
        // POST: /Estado/Edit/5

        [HttpPost]
        public ActionResult Edit(Estado estado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(estado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(estado);
        }

        //
        // GET: /Estado/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Estado estado = db.Estados.Find(id);
            if (estado == null)
            {
                return HttpNotFound();
            }
            return View(estado);
        }

        //
        // POST: /Estado/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Estado estado = db.Estados.Find(id);
            db.Estados.Remove(estado);
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