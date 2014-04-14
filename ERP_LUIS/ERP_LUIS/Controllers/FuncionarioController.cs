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
    public class FuncionarioController : Controller
    {
        private ERPContext db = new ERPContext();

        //
        // GET: /Funcionario/

        public ActionResult Index()
        {
            var funcionarios = db.Funcionarios.Include(f => f.Cidade).Include(f => f.Departamento).Include(f => f.Cargo);
            return View(funcionarios.ToList());
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
            ViewBag.IdCidade = new SelectList(db.Cidades, "IdCidade", "Nome");
            ViewBag.IdDepartamento = new SelectList(db.Departamentos, "IdDepartamento", "Descricao");
            ViewBag.IdCargo = new SelectList(db.Cargos, "IdCargo", "Descricao");
            return View();
        }

        //
        // POST: /Funcionario/Create

        [HttpPost]
        public ActionResult Create(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                db.Funcionarios.Add(funcionario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCidade = new SelectList(db.Cidades, "IdCidade", "Nome", funcionario.IdCidade);
            ViewBag.IdDepartamento = new SelectList(db.Departamentos, "IdDepartamento", "Descricao", funcionario.IdDepartamento);
            ViewBag.IdCargo = new SelectList(db.Cargos, "IdCargo", "Descricao", funcionario.IdCargo);
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
            ViewBag.IdCidade = new SelectList(db.Cidades, "IdCidade", "Nome", funcionario.IdCidade);
            ViewBag.IdDepartamento = new SelectList(db.Departamentos, "IdDepartamento", "Descricao", funcionario.IdDepartamento);
            ViewBag.IdCargo = new SelectList(db.Cargos, "IdCargo", "Descricao", funcionario.IdCargo);
            return View(funcionario);
        }

        //
        // POST: /Funcionario/Edit/5

        [HttpPost]
        public ActionResult Edit(Funcionario funcionario)
        {
            if (ModelState.IsValid)
            {
                db.Entry(funcionario).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCidade = new SelectList(db.Cidades, "IdCidade", "Nome", funcionario.IdCidade);
            ViewBag.IdDepartamento = new SelectList(db.Departamentos, "IdDepartamento", "Descricao", funcionario.IdDepartamento);
            ViewBag.IdCargo = new SelectList(db.Cargos, "IdCargo", "Descricao", funcionario.IdCargo);
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
        public ActionResult DeleteConfirmed(int id)
        {
            Funcionario funcionario = db.Funcionarios.Find(id);
            db.Funcionarios.Remove(funcionario);
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