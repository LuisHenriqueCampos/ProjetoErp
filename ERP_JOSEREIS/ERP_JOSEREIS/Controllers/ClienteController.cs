using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_JOSEREIS.Models;
using ERP_JOSEREIS.ViewModels;

namespace ERP_JOSEREIS.Controllers
{
    public class ClienteController : Controller
    {
        private ERPContext db = new ERPContext();

        //
        // GET: /Cliente/

        public ActionResult Index()
        {
            return View(db.Clientes.Include(c => c.Pessoa).ToList());

        }

        //
        // GET: /Cliente/Details/5

        public ActionResult Details(int id = 0)
        {
            Cliente cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        //
        // GET: /Cliente/Create

        public ActionResult CreatePF()
        {
            Cliente cliente = new Cliente();
            PessoaFisica pf = new PessoaFisica();
            var clienteVM = new ClienteViewModel(cliente, pf);
            return View("Edit", clienteVM);
        }

        //
        // POST: /Cliente/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        //
        // GET: /Cliente/Edit/5

        public ActionResult Edit(int id = 0)
        {

            Cliente cliente = db.Clientes.Find(id);
            PessoaFisica pf;
            PessoaJuridica pj;
            
            ClienteViewModel clienteVM;
            if (cliente == null)
            {
                return HttpNotFound();
            }
            try
            {
                pf = db.PessoasFisicas.Find(id);
                clienteVM = new ClienteViewModel(cliente, pf);
                return View(clienteVM);
            }
            catch
            {
                pj = db.PessoasJuridicas.Find(id);
                clienteVM = new ClienteViewModel(cliente, pj);
                return View(clienteVM);
            }

           
        }

        //
        // POST: /Cliente/Edit/5

        [HttpPost]
        
        public ActionResult EditPF(Cliente cliente, PessoaFisica pessoaFisica)
        {

           // cliente.IdCliente = pessoaFisica.IdPessoa;
           // pessoaFisica.DataCadastro = DateTime.Now;
            if (ModelState.IsValid)
            {
                if (pessoaFisica.IdPessoa != 0)
                {
                    db.Entry(cliente).State = EntityState.Modified;
                    db.Entry(pessoaFisica).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    db.Clientes.Add(cliente);
                    db.PessoasFisicas.Add(pessoaFisica);
                    db.SaveChanges();
                }
            }
            ClienteViewModel clienteVM = new ClienteViewModel(cliente, pessoaFisica);
            return View("Edit",cliente);
        }

        //
        // GET: /Cliente/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Cliente cliente = db.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        //
        // POST: /Cliente/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cliente cliente = db.Clientes.Find(id);
            db.Clientes.Remove(cliente);
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