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
    public class FornecedorController : Controller
    {
        private ERPContext db = new ERPContext();

        //
        // GET: /Fornecedor/

        public ActionResult Index()
        {
            return View(db.Fornecedores.Include(f => f.pessoa).ToList());
        }

        //
        // GET: /Fornecedor/Details/5

        public ActionResult Details(int id = 0)
        {
            Fornecedor Fornecedor = db.Fornecedores.Find(id);

            PessoaFisica pf;
            PessoaJuridica pj;

            if (Fornecedor == null)
            {
                return HttpNotFound();
            }

            try
            {
                pf = db.PessoasFisicas.Find(id);
                return View(new FornecedorViewModel(Fornecedor, pf));
            }

            catch
            {
                pj = db.PessoasJuridicas.Find(id);
                return View(new FornecedorViewModel(Fornecedor, pj));
            }
        }

        //
        // GET: /Fornecedor/Create

        public ActionResult CreatePF()
        {
            Fornecedor Fornecedor = new Fornecedor();
            PessoaFisica pessoaFisica = new PessoaFisica();
            FornecedorViewModel viewModel = new FornecedorViewModel(Fornecedor, pessoaFisica);

            return View("Edit", viewModel);
        }

        public ActionResult CreatePJ()
        {
            Fornecedor Fornecedor = new Fornecedor();
            PessoaJuridica pessoaJuridica = new PessoaJuridica();
            FornecedorViewModel viewModel = new FornecedorViewModel(Fornecedor, pessoaJuridica);

            return View("Edit", viewModel);
        }

        //
        // POST: /Fornecedor/Create

        [HttpPost]
        public ActionResult Create(Fornecedor Fornecedor)
        {
            if (ModelState.IsValid)
            {
                db.Fornecedores.Add(Fornecedor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Fornecedor);
        }

        //
        // GET: /Fornecedor/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Fornecedor Fornecedor = db.Fornecedores.Find(id);

            try
            {
                var pessoa = db.PessoasFisicas.Find(id);
                return View(new FornecedorViewModel(Fornecedor, pessoa));
            }

            catch (Exception ex)
            {
                var pessoa = db.PessoasJuridicas.Find(id);
                return View(new FornecedorViewModel(Fornecedor, pessoa));
            }
        }

        //
        // POST: /Fornecedor/Edit/5

        [HttpPost]
        public ActionResult Edit(Fornecedor Fornecedor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(Fornecedor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(Fornecedor);
        }

        [HttpPost]
        public ActionResult EditPF(Fornecedor Fornecedor, PessoaFisica pessoaFisica)
        {
            pessoaFisica.DataCadastro = DateTime.Now;

            if (ModelState.IsValid)
            {
                if (pessoaFisica.IdPessoa == 0)
                {
                    db.Fornecedores.Add(Fornecedor);
                    db.PessoasFisicas.Add(pessoaFisica);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                else
                {
                    db.Entry(Fornecedor).State = EntityState.Modified;
                    db.Entry(pessoaFisica).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            FornecedorViewModel viewModel = new FornecedorViewModel(Fornecedor, pessoaFisica);
            return View("Edit", viewModel);
        }

        [HttpPost]
        public ActionResult EditPJ(Fornecedor Fornecedor, PessoaJuridica pessoaJuridica)
        {
            pessoaJuridica.DataCadastro = DateTime.Now;

            if (ModelState.IsValid)
            {
                if (pessoaJuridica.IdPessoa == 0)
                {
                    db.Fornecedores.Add(Fornecedor);
                    db.PessoasJuridicas.Add(pessoaJuridica);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }

                else
                {
                    db.Entry(Fornecedor).State = EntityState.Modified;
                    db.Entry(pessoaJuridica).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            FornecedorViewModel viewModel = new FornecedorViewModel(Fornecedor, pessoaJuridica);
            return View("Edit", viewModel);
        }

        //
        // GET: /Fornecedor/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Fornecedor Fornecedor = db.Fornecedores.Find(id);
            PessoaFisica pf;
            PessoaJuridica pj;

            if (Fornecedor == null)
            {
                return HttpNotFound();
            }

            try
            {
                pf = db.PessoasFisicas.Find(id);
                return View(new FornecedorViewModel(Fornecedor, pf));
            }

            catch
            {
                pj = db.PessoasJuridicas.Find(id);
                return View(new FornecedorViewModel(Fornecedor, pj));
            }
        }

        //
        // POST: /Fornecedor/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Fornecedor Fornecedor = db.Fornecedores.Find(id);
            db.Fornecedores.Remove(Fornecedor);
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