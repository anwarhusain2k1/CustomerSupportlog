using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using customersupportlogger;
using MVC.Models;

namespace MVC.Controllers
{
    public class customerController : Controller
    {
        // GET: customer
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(userinfo user)
        {
            DAL dal = new DAL();
            bool status = dal.login(user.UserId, user.Password);
            if (status)
                return RedirectToAction("compliant");
            else
                return View();
            
        }

        // GET: customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: customer/Create
        public ActionResult compliant()
        {
            return View();
        }

        // POST: customer/Create
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

        // GET: customer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: customer/Edit/5
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

        // GET: customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: customer/Delete/5
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
