﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ASPNET_WEB_MVC.Models;

namespace ASPNET_WEB_MVC.Controllers
{
    public class AtletasController : Controller
    {
        private ASPNET_WEB_MVCContext db = new ASPNET_WEB_MVCContext();


        public ViewResult DetalharAtleta(int id)
        {
            Atleta atleta = null;

            if (id != 0)
            {
                atleta = db.Atletas.Find(id);
            }

            if (atleta != null) return View(atleta);
            return new ViewResult();
        }

        // GET: Atletas
        public ActionResult Index()
        {
            return View(db.Atletas.ToList());
        }

        // GET: Atletas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Atleta atleta = db.Atletas.Find(id);
            if (atleta == null)
            {
                return HttpNotFound();
            }
            return View(atleta);
        }

        // GET: Atletas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Atletas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome,Modalidade,Idade,Celular")] Atleta atleta)
        {
            if (ModelState.IsValid)
            {
                db.Atletas.Add(atleta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(atleta);
        }

        // GET: Atletas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Atleta atleta = db.Atletas.Find(id);
            if (atleta == null)
            {
                return HttpNotFound();
            }
            return View(atleta);
        }

        // POST: Atletas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,Modalidade,Idade,Celular")] Atleta atleta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(atleta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(atleta);
        }

        // GET: Atletas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Atleta atleta = db.Atletas.Find(id);
            if (atleta == null)
            {
                return HttpNotFound();
            }
            return View(atleta);
        }

        // POST: Atletas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Atleta atleta = db.Atletas.Find(id);
            db.Atletas.Remove(atleta);
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
