using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RickyFeliguete.Models.AccountModels;
using System.ComponentModel.DataAnnotations;

namespace RickyFeliguete.Controllers
{
    public class AvailableUsersController : Controller
    {
        // GET: AvailableUsers
        public ActionResult Index()
        {
            return View();
        }

        // GET: AvailableUsers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AvailableUsers/Create
        public ActionResult Create()
        {
            AvailableUser usr = new AvailableUser();
            return View(usr);
        }

        // POST: AvailableUsers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public string Create(AvailableUser usr)
        //public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                //return RedirectToAction("Index");
                // return "nome de usuario = " + usr.UserName + "; senha = " + usr.UserPassword + "; nome completo = " + usr.FullName;

                if (ModelState.IsValid)
                {
                    return "nome de usuario = " + usr.UserName + "; senha = " + usr.UserPassword + "; nome completo = " + usr.FullName;
                }
                else
                    return null;
            }
            catch
            {
                return "erro";
                //return View("~/Views/Shared/Error.cshtml");
            }
        }

        // GET: AvailableUsers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AvailableUsers/Edit/5
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

        // GET: AvailableUsers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AvailableUsers/Delete/5
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

        public ActionResult Login()
        {

            ViewBag.Title = "Login";
            return View(new AvailableUser());
        }

        [HttpPost]
        public string Login(AvailableUser user)
        {
            ViewBag.Title = "Testing Login action";
            ViewBag.UserName = user.FullName;
            return ViewBag.Title + ViewBag.UserName;
        }
    }
}
