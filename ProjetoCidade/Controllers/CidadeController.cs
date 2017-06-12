using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjetoCidade.Data;
using ProjetoCidade.Models;

namespace ProjetoCidade.Controllers
{
    public class CidadeController : Controller
    {
        private DataContext db = new DataContext();

        // GET: Cidade
        public ActionResult Index()
        {
            var cidade = db.cidade.Include(c => c.estado);
            return View(cidade.ToList());
        }

        // GET: Cidade/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cidade cidade = db.cidade.Find(id);
            if (cidade == null)
            {
                return HttpNotFound();
            }
            return View(cidade);
        }

        // GET: Cidade/Create
        public ActionResult Create()
        {
            ViewBag.estado_id = new SelectList(db.estado, "id", "nomeEstado");
            return View();
        }

        // POST: Cidade/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nomeCidade,estado_id")] Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                db.cidade.Add(cidade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.estado_id = new SelectList(db.estado, "id", "nomeEstado", cidade.estado_id);
            return View(cidade);
        }

        // GET: Cidade/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cidade cidade = db.cidade.Find(id);
            if (cidade == null)
            {
                return HttpNotFound();
            }
            ViewBag.estado_id = new SelectList(db.estado, "id", "nomeEstado", cidade.estado_id);
            return View(cidade);
        }

        // POST: Cidade/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nomeCidade,estado_id")] Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cidade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.estado_id = new SelectList(db.estado, "id", "nomeEstado", cidade.estado_id);
            return View(cidade);
        }

        // GET: Cidade/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cidade cidade = db.cidade.Find(id);
            if (cidade == null)
            {
                return HttpNotFound();
            }
            return View(cidade);
        }

        // POST: Cidade/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cidade cidade = db.cidade.Find(id);
            db.cidade.Remove(cidade);
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
