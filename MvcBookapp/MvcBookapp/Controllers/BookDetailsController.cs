using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcBookapp.Data;
using MvcBookapp.Models;

namespace MvcBookapp.Controllers
{
    public class BookDetailsController : Controller
    {
        private MvcBookappContext db = new MvcBookappContext();

        

        // GET: BookDetails
        public ViewResult Index(string Publishers, string strSearch)
        {
            //Select all Book records
            var books = from b in db.BookDetails
                        select b;

            //Get list of Book publisher
            var publisherList = from c in books
                                orderby c.Publisher
                                select c.Publisher;

            //Set distinct list of publishers in ViewBag property
            ViewBag.Publishers = new SelectList(publisherList.Distinct());

            //Search records by Book Name 
            if (!string.IsNullOrEmpty(strSearch))
                books = books.Where(m => m.BookName.Contains(strSearch));

            //Search records by Publisher
            if (!string.IsNullOrEmpty(Publishers))
                books = books.Where(m => m.Publisher == Publishers);
            return View(books);
        }

        // GET: BookDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookDetails bookDetails = db.BookDetails.Find(id);
            if (bookDetails == null)
            {
                return HttpNotFound();
            }
            return View(bookDetails);
        }

        // GET: BookDetails/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookId,BookName,Author,Publisher,Price")] BookDetails bookDetails)
        {
            if (ModelState.IsValid)
            {
                db.BookDetails.Add(bookDetails);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bookDetails);
        }

        // GET: BookDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookDetails bookDetails = db.BookDetails.Find(id);
            if (bookDetails == null)
            {
                return HttpNotFound();
            }
            return View(bookDetails);
        }

        // POST: BookDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookId,BookName,Author,Publisher,Price")] BookDetails bookDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bookDetails).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bookDetails);
        }

        // GET: BookDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BookDetails bookDetails = db.BookDetails.Find(id);
            if (bookDetails == null)
            {
                return HttpNotFound();
            }
            return View(bookDetails);
        }

        // POST: BookDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BookDetails bookDetails = db.BookDetails.Find(id);
            db.BookDetails.Remove(bookDetails);
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
