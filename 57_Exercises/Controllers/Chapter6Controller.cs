using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Newtonsoft.Json;
using _57_Exercises.Models;
using _57_Exercises.ViewModels;

namespace _57_Exercises.Controllers
{
    public class Chapter6Controller : Controller
    {
        public ActionResult _28()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public ContentResult _28(Ex28ViewModel data)
        {
            var sum = data.Values.Sum();

            return Content(sum.ToString());
        }

        public ActionResult _30()
        {
            return View(Ex30.GenerateMultiTable0to12());
        }

        public ActionResult _32()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult _32_Answer(Ex32ViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ErrorMsg = "Invalid data!";
            }

            TempData["RightNumber"] = Ex32.GetRandomRightNumber(vm);

            return View(vm);
        }

        [System.Web.Mvc.HttpPost]
        public PartialViewResult _32_Guess(Ex32ViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ErrorMsg = "Invalid data!";
            }

            int rightNumber = int.Parse(TempData["RightNumber"].ToString());
            TempData["RightNumber"] = rightNumber;

            vm.AnswerStatus = Ex32.CheckAnswer(vm.Answer, rightNumber);

            return PartialView("_32_partial", vm);
        }
    }
}