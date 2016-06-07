using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1;
using DbLibrary.Models;
using DbLibrary.Services;

namespace WebApplication1.Controllers
{
    public class TestUserController : Controller
    {
        // GET: TestUser
        public ActionResult Index()
        {
            return View(dbServices.getAll());
        }
        public ActionResult Details(int? id)
        {
            if (id == null) {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestUserModel testModel = dbServices.Find(id);
            if (testModel == null)
            {
                return HttpNotFound();
            }
            return View(testModel);

        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "UserID,first_name,last_name")] TestUserModel testModel)
        {
            if (ModelState.IsValid)
            {
                dbServices.Add(testModel);
                dbServices.Save();
                return RedirectToAction("Index");
            }
            return View(testModel);
        }

        public ActionResult Edit(int? id)
        {
            if(id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestUserModel testModel = new TestUserModel();
            testModel = dbServices.Find(id);
            if (testModel == null)
            {
                return HttpNotFound();
            }
            return View(testModel);
        }
        [HttpPost]
        public ActionResult Edit([Bind(Include = "UserID,first_name,last_name")] TestUserModel testModel)
        {
            if (ModelState.IsValid)
            {
                var id = testModel.UserID;
                dbServices.Edit(testModel,id);
                return RedirectToAction("Index");
            }
            return View(testModel);
        }
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TestUserModel testModel = dbServices.Find(id);
            if (testModel == null)
            {
                return HttpNotFound();
            }
            return View(testModel);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            TestUserModel testModel = dbServices.Find(id);
            dbServices.Remove(testModel);
            return RedirectToAction("Index");
        }
        protected override void Dispose(bool disposing)
        {
            if(disposing)
                {
                dbServices.Dispose();
            }
            base.Dispose(disposing);
        }



    }
}