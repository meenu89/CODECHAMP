using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class RegistrationController : Controller
    {
        Context db = new Context();
        Registration rg = new Registration();
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {
            rg.companyName = collection["companyName"];
            rg.CompanyEmail = collection["CompanyEmail"];
            rg.TestDate =Convert.ToDateTime(collection["TestDate"]).Date;
            rg.Password = collection["Password"];
            rg.TestDuration =int.Parse(collection["TestDuration"]);

            db.Registrations.Add(rg);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        // GET: Registration/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Registration/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registration/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Registration/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Registration/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Registration/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Registration/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
