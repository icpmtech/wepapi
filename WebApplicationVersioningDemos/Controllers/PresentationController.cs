﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationVersioningDemos.Controllers
{
    public class PresentationController : Controller
    {
        // GET: Presentation
        public ActionResult Index()
        {
            return View();
        }

        // GET: Presentation/Why
        public ActionResult Why()
        {
            return View();
        }

        // GET: Presentation/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Presentation/Create
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

        // GET: Presentation/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Presentation/Edit/5
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

        // GET: Presentation/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Presentation/Delete/5
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
