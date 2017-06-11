using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _2015147458_ENT;
using _2015147458_PER;
using _2015147458_ENT.IRepositories;

namespace _2015147458_MVC.Controllers
{
    public class TipoPlansController : Controller
    {
        //private MovieStoreContext db = new MovieStoreContext();

        private readonly IUnityOfWork _UnityOfWork;

        public TipoPlansController(IUnityOfWork unityOfWork)
        {
            _UnityOfWork = unityOfWork;
        }

        public TipoPlansController()
        {

        }

        // GET: Genres
        public ActionResult Index()
        {
            //return View(db.Genres.ToList());
            return View(_UnityOfWork.TipoPlan.GetAll());
        }

        // GET: Genres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //Genre genre = db.Genres.Find(id);
            TipoPlan tipoPlan = _UnityOfWork.TipoPlan.Get(id);
            if (tipoPlan == null)
            {
                return HttpNotFound();
            }
            return View(tipoPlan);
        }

        // GET: Genres/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Genres/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GenreId,Description")] TipoPlan tipoPlan)
        {
            if (ModelState.IsValid)
            {
                //db.Genres.Add(genre);
                _UnityOfWork.TipoPlan.Add(tipoPlan);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoPlan);
        }

        // GET: Genres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Genre genre = db.Genres.Find(id);
            TipoPlan tipoPlan = _UnityOfWork.TipoPlan.Get(id);
            if (tipoPlan == null)
            {
                return HttpNotFound();
            }
            return View(tipoPlan);
        }

        // POST: Genres/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GenreId,Description")] TipoPlan tipoPlan)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(genre).State = EntityState.Modified;
                _UnityOfWork.StateModified(tipoPlan);

                //db.SaveChanges();
                _UnityOfWork.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(tipoPlan);
        }

        // GET: Genres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Genre genre = db.Genres.Find(id);
            TipoPlan tipoPlan = _UnityOfWork.TipoPlan.Get(id);
            if (tipoPlan == null)
            {
                return HttpNotFound();
            }
            return View(tipoPlan);
        }

        // POST: Genres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //Genre genre = db.Genres.Find(id);
            TipoPlan tipoPlan = _UnityOfWork.TipoPlan.Get(id);

            //db.Genres.Remove(genre);
            _UnityOfWork.TipoPlan.Delete(tipoPlan);

            //db.SaveChanges();
            _UnityOfWork.SaveChanges();

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
                _UnityOfWork.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
