﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_ANDERSON.Models;

namespace ERP_ANDERSON.Controllers
{
    public class DepartamentoController : Controller
    {
        private ERPContext db = new ERPContext();

        //
        // GET: /Departamento/

        public ActionResult Index()
        {
            return View(db.Departamentos.ToList());
        }

        //
        // GET: /Departamento/Details/5

        public ActionResult Details(int id = 0)
        {
            Departamento departamento = db.Departamentos.Find(id);
            if (departamento == null)
            {
                return HttpNotFound();
            }
            return View(departamento);
        }

        //
        // GET: /Departamento/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Departamento/Create

        [HttpPost]
        public ActionResult Create(Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                db.Departamentos.Add(departamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(departamento);
        }

        //
        // GET: /Departamento/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Departamento departamento = db.Departamentos.Find(id);
            if (departamento == null)
            {
                return HttpNotFound();
            }
            return View(departamento);
        }

        //
        // POST: /Departamento/Edit/5

        [HttpPost]
        public ActionResult Edit(Departamento departamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(departamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(departamento);
        }

        //
        // GET: /Departamento/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Departamento departamento = db.Departamentos.Find(id);
            if (departamento == null)
            {
                return HttpNotFound();
            }
            return View(departamento);
        }

        //
        // POST: /Departamento/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Departamento departamento = db.Departamentos.Find(id);
            db.Departamentos.Remove(departamento);
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