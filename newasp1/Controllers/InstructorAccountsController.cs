using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using newasp1.Models;

namespace newasp1.Controllers
{
    public class InstructorAccountsController : Controller
    {
        private Model1 db = new Model1();

        // GET: InstructorAccounts
        public ActionResult Index()
        {
            return View(db.InstructorAccounts.ToList());
        }

        // GET: InstructorAccounts/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    InstructorAccount instructorAccount = db.InstructorAccounts.Find(id);
        //    if (instructorAccount == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(instructorAccount);
        //}

        // GET: InstructorAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InstructorAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
      
        public ActionResult Create([Bind(Include = "id,FullName,UserName,Email,Password")] InstructorLogins instructorAccount)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                db.InstructorAccounts.Add(instructorAccount);
                db.SaveChanges();
               message = "details saved";
               ViewBag.DuplicateMessage = message;
                return RedirectToAction("Index","Post");
            }
            else 
            {
              
                message ="error  ";
                ViewBag.DuplicateMessage = message;
               // return RedirectToAction("InsLogin");
            }
            return View(instructorAccount);




        }

        //// GET: InstructorAccounts/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    InstructorAccount instructorAccount = db.InstructorAccounts.Find(id);
        //    if (instructorAccount == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(instructorAccount);
        //}

        //// POST: InstructorAccounts/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "id,FullName,UserName,Email,Password")] InstructorAccount instructorAccount)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(instructorAccount).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(instructorAccount);
        //}

        //// GET: InstructorAccounts/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    InstructorAccount instructorAccount = db.InstructorAccounts.Find(id);
        //    if (instructorAccount == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(instructorAccount);
        //}

        //// POST: InstructorAccounts/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    InstructorAccount instructorAccount = db.InstructorAccounts.Find(id);
        //    db.InstructorAccounts.Remove(instructorAccount);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
