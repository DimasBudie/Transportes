using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoTransportes.Models;

namespace ProjetoTransportes.Controllers
{
    public class MotoristaController : Controller
    {
        private TransporteDBContext db = new TransporteDBContext();

        // GET: Motorista
        public ActionResult Index()
        {
            try
            {
                return View(db.Motoristas.ToList());
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        // GET: Motorista/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motorista motorista = db.Motoristas.Find(id);
            if (motorista == null)
            {
                return HttpNotFound();
            }
            return View(motorista);
        }

        // GET: Motorista/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Motorista/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,NomeCompleto,CPF,RG,UF,Emissor,DataEmissao,DataNascimento,Endereco,Numero,Complemento,Bairro,Cidade,Estado,Telefone,Celular,Celular2,Operadora,RegistroCNH,Validade,PrimeiraHabilitacao,Cedula,DataEmissaoCNH,Detran,PontuacaoAtual")] Motorista motorista)
        {
            if (ModelState.IsValid)
            {
                db.Motoristas.Add(motorista);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(motorista);
        }

        // GET: Motorista/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motorista motorista = db.Motoristas.Find(id);
            if (motorista == null)
            {
                return HttpNotFound();
            }
            return View(motorista);
        }

        // POST: Motorista/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,NomeCompleto,CPF,RG,UF,Emissor,DataEmissao,DataNascimento,Endereco,Numero,Complemento,Bairro,Cidade,Estado,Telefone,Celular,Celular2,Operadora,RegistroCNH,Validade,PrimeiraHabilitacao,Cedula,DataEmissaoCNH,Detran,PontuacaoAtual")] Motorista motorista)
        {
            if (ModelState.IsValid)
            {
                db.Entry(motorista).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(motorista);
        }

        // GET: Motorista/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motorista motorista = db.Motoristas.Find(id);
            if (motorista == null)
            {
                return HttpNotFound();
            }
            return View(motorista);
        }

        // POST: Motorista/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Motorista motorista = db.Motoristas.Find(id);
            db.Motoristas.Remove(motorista);
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
