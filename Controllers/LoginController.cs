﻿using SmartPax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartPax.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }


        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            SmartPaxEntities cbe = new SmartPaxEntities();
            var s = cbe.Viax_Login(model.UserName, model.Password);

          
            if (s != null )
            {
                
                return View("/RoleManagement/Create");
            }
            else if (s == null)

            {
                ViewBag.NotValidUser = model.UserName;

            }
            else
            {
               // ViewBag.Failedcount = item;
            }
            //wayne
            return View("RoleManagement/Create");
        }
        // POST: Login/Create
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

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
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

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
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
