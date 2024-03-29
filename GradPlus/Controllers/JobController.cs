﻿using System;
using GradPlus.Services.IServices;
using GradPlus.Services.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GradPlus.Controllers
{
    public class JobController : Controller
    {
        private IJobServices jobServices;
        public JobController()
        {
            jobServices = new JobServices();
        }

        // GET: Job

        public ActionResult GetJobs()
        {
            //List of jobs
            return View(jobServices.GetJobs());
        }

        public ActionResult GetJob(int id)
        {
            //Detail of each Job
            return View(jobServices.GetJob(id));
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: Job/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Job/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Job/Create
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

        // GET: Job/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Job/Edit/5
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

        // GET: Job/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Job/Delete/5
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
