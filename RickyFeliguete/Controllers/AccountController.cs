using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RickyFeliguete.Models;

namespace RickyFeliguete.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AvailableUserList()
        {
            ViewBag.Text = "Controller Text";
            return View(Models.AccountModels.AvailableUser.AllUsers());
        }
    }
}