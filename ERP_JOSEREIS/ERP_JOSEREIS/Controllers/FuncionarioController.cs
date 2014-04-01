using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_JOSEREIS.Models;

namespace ERP_JOSEREIS.Controllers
{
    public class FuncionarioController : Controller
    {
        private ERPContext db = new ERPContext();

        //
        // GET: /Funcionario/

        public ActionResult Index()
        {
            return View(db.Funcionarios.ToList());
        }

        //
        // GET: /Funcionario/Details/5

        public ActionResult Details(int id = 0)
        {
            Funcionario funcionario = db.Funcionarios.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        //
        // GET: /Funcionario/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Funcionario/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                db.Pessoas.Add(funcionario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(funcionario);
        }

        //
        // GET: /Funcionario/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Funcionario funcionario = db.Funcionarios.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        //
        // POST: /Funcionario/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(funcionario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(funcionario);
        }

        //
        // GET: /Funcionario/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Funcionario funcionario = db.Funcionarios.Find(id);
            if (funcionario == null)
            {
                return HttpNotFound();
            }
            return View(funcionario);
        }

        //
        // POST: /Funcionario/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Funcionario funcionario = db.Funcionarios.Find(id);
            db.Pessoas.Remove(funcionario);
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