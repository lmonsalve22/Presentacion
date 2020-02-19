using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Maqueta.Models;

namespace Maqueta.Controllers
{
    public class ORIGENDATOController : Controller
    {
        private sudaustralEntities1 db = new sudaustralEntities1();

        // GET: ORIGENDATO
        public ActionResult Index()
        {
            return View(db.ORIGENDATOS.ToList());
        }

        // GET: ORIGENDATO/Details/5
        public ActionResult Details(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ORIGENDATO oRIGENDATO = db.ORIGENDATOS.Find(id);
            if (oRIGENDATO == null)
            {
                return HttpNotFound();
            }
            return View(oRIGENDATO);
        }

        // GET: ORIGENDATO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ORIGENDATO/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,DESCRIPCION,NOMBRE,NOMBREARCHIVO,TIPOENTIDAD,ORGANISMO,AUTOR,LINK,API,LINKAPI,APIPUBLICA,TAG,VOLUMETRIA,UNIDADVOLUMETRIA,RUTANAVEGACION,ENLACEDESCARGA,OBSERVACIONES,RUTACARPETA,FECHACONSULTA,FECHAINICIODATOS,FECHAFINALDATOS")] ORIGENDATO oRIGENDATO)
        {
            if (ModelState.IsValid)
            {
                db.ORIGENDATOS.Add(oRIGENDATO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(oRIGENDATO);
        }

        // GET: ORIGENDATO/Edit/5
        public ActionResult Edit(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ORIGENDATO oRIGENDATO = db.ORIGENDATOS.Find(id);
            if (oRIGENDATO == null)
            {
                return HttpNotFound();
            }
            return View(oRIGENDATO);
        }

        // POST: ORIGENDATO/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,DESCRIPCION,NOMBRE,NOMBREARCHIVO,TIPOENTIDAD,ORGANISMO,AUTOR,LINK,API,LINKAPI,APIPUBLICA,TAG,VOLUMETRIA,UNIDADVOLUMETRIA,RUTANAVEGACION,ENLACEDESCARGA,OBSERVACIONES,RUTACARPETA,FECHACONSULTA,FECHAINICIODATOS,FECHAFINALDATOS")] ORIGENDATO oRIGENDATO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(oRIGENDATO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(oRIGENDATO);
        }

        // GET: ORIGENDATO/Delete/5
        public ActionResult Delete(double? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ORIGENDATO oRIGENDATO = db.ORIGENDATOS.Find(id);
            if (oRIGENDATO == null)
            {
                return HttpNotFound();
            }
            return View(oRIGENDATO);
        }

        // POST: ORIGENDATO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(double id)
        {
            ORIGENDATO oRIGENDATO = db.ORIGENDATOS.Find(id);
            db.ORIGENDATOS.Remove(oRIGENDATO);
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
