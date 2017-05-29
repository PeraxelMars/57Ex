using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using _57_Exercises.Models;
using _57_Exercises.ViewModels;

namespace _57_Exercises.Controllers
{
    public class Chapter5Controller : Controller
    {
        public ActionResult _24()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public PartialViewResult _24([FromBody]Ex24ViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ErrorMsg = "Invalid data!";
            }
            else
            {
                Ex24 ex = new Ex24(vm.S1, vm.S2);
                vm.IsAnagram = ex.IsAnagram;
            }

            return PartialView("_24_partial", vm);
        }

        public ActionResult _25()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public PartialViewResult _25(Ex25ViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ErrorMsg = "Invalid data!";
            }
            else
            {
                vm.PasswordStrengt = Ex25.ValidatePassword(vm.Password);
            }

            return PartialView("_25_partial", vm);
        }

        [System.Web.Mvc.HttpGet]
        public ContentResult _25_PwStrengt(string pw)
        {
            return Content(Ex25.ValidatePassword(pw).ToString());
        }

        public ActionResult _27()
        {
            return View(new Ex27ViewModel());
        }

        [System.Web.Mvc.HttpPost]
        public PartialViewResult _27(Ex27ViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ErrorMsg = "Invalid data!";
            }

            vm.ZIP = vm.ZIP.Replace(" ", "");

            return PartialView("_27_partial", vm);
        }
    }
}