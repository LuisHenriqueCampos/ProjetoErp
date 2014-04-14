using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ERP_ANDERSON.Models;
using ERP_ANDERSON.ViewModel;

namespace ERP_ANDERSON.Controllers
{
    public class ClienteController : Controller
    {
        private ERPContext db = new ERPContext();

        //
        // GET: /Cliente/

        public ActionResult Index()
        {
            return View(db.Clientes.Include(c => c.pessoa).ToList());
        }

        //
        // GET: /Cliente/Details/5

        public ActionResult Details(int id = 0)
        {
            Cliente cliente = db.Clientes.Find(id);

            PessoaFisica pf;
            PessoaJuridica pj;

            if (cliente == null)
            {
                return HttpNotFound();
            }

            try
            {
                pf = db.PessoasFisicas.Find(id);
                return View(new ClienteViewModel(cliente, pf));
            }

            catch
            {
                pj = db.PessoasJuridicas.Find(id);
                return View(new ClienteViewModel(cliente, pj));
            }
        }

        //
        // GET: /Cliente/Create

        public ActionResult CreatePF()
        {
            Cliente cliente = new Cliente();
            PessoaFisica pessoaFisica = new PessoaFisica();
            ClienteViewModel viewModel = new ClienteViewModel(cliente, pessoaFisica);

            return View("Edit", viewModel);
        }

        public ActionResult CreatePJ()
        {
            Cliente cliente = new Cliente();
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            ClienteViewModel viewModel = new ClienteViewModel(cliente, pessoaJuridica);

            return View("Edit", viewModel);
        }

        //
        // POST: /Cliente/Create

        [HttpPost]
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

            try
            {
                var pessoa = db.PessoasFisicas.Find(id);
                return View(new ClienteViewModel(cliente, pessoa));
            }

            catch (Exception ex)
            {
                var pessoa = db.PessoasJuridicas.Find(id);
                return View(new ClienteViewModel(cliente, pessoa));
            }
        }

        //
        // POST: /Cliente/Edit/5

        [HttpPost]
        public ActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cliente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        [HttpPost]
        public ActionResult EditPF(Cliente cliente, PessoaFisica pessoaFisica)
        {
            pessoaFisica.DataCadastro = DateTime.Now;

            if (ModelState.IsValid)
            {
                PessoaFisica pf = db.PessoasFisicas.FirstOrDefault(x => x.CPF == pessoaFisica.CPF);
                Cliente c = db.Clientes.Find(cliente.IdCliente);

                if (pf != null && c == null)
                {
                    cliente.IdCliente = pf.IdPessoa;
                    pessoaFisica.IdPessoa = pf.IdPessoa;
                    db.Clientes.Add(cliente);
                    db.SaveChanges();
                }

                if (pessoaFisica.IdPessoa == 0)
                {
                    db.Clientes.Add(cliente);
                    db.PessoasFisicas.Add(pessoaFisica);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                else
                {
                    db.Entry(cliente).State = EntityState.Modified;
                    db.Entry(pessoaFisica).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            ClienteViewModel viewModel = new ClienteViewModel(cliente, pessoaFisica);
            return View("Edit", viewModel);
        }

        [HttpPost]
        public ActionResult EditPJ(Cliente cliente, PessoaJuridica pessoaJuridica)
        {
            pessoaJuridica.DataCadastro = DateTime.Now;

            if (ModelState.IsValid)
            {
                PessoaJuridica pj = db.PessoasJuridicas.FirstOrDefault(x => x.CNPJ == pessoaJuridica.CNPJ);
                Cliente c = db.Clientes.Find(cliente.IdCliente);

                if (pj != null && c == null)
                {
                    cliente.IdCliente = pj.IdPessoa;
                    pessoaJuridica.IdPessoa = pj.IdPessoa;
                    db.Clientes.Add(cliente);
                    db.SaveChanges();
                }

                if (pessoaJuridica.IdPessoa == 0)
                {
                    db.Clientes.Add(cliente);
                    db.PessoasJuridicas.Add(pessoaJuridica);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                else
                {
                    db.Entry(cliente).State = EntityState.Modified;
                    db.Entry(pessoaJuridica).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            ClienteViewModel viewModel = new ClienteViewModel(cliente, pessoaJuridica);
            return View("Edit", viewModel);
        }

        //
        // GET: /Cliente/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Cliente cliente = db.Clientes.Find(id);
            PessoaFisica pf;
            PessoaJuridica pj;

            if (cliente == null)
            {
                return HttpNotFound();
            }

            try
            {
                pf = db.PessoasFisicas.Find(id);
                return View(new ClienteViewModel(cliente, pf));
            }

            catch
            {
                pj = db.PessoasJuridicas.Find(id);
                return View(new ClienteViewModel(cliente, pj));
            }
        }

        //
        // POST: /Cliente/Delete/5

        [HttpPost, ActionName("Delete")]
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