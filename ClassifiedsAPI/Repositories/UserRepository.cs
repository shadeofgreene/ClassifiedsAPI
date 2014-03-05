using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClassifiedsAPI.Repositories
{
    public class UserRepository : Controller
    {
        //
        // GET: /UserRepository/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /UserRepository/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /UserRepository/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /UserRepository/Create

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

        //
        // GET: /UserRepository/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /UserRepository/Edit/5

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

        //
        // GET: /UserRepository/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /UserRepository/Delete/5

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
