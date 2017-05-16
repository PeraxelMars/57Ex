using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.ModelBinding;
using System.Web.Mvc;
using Newtonsoft.Json;
using _57_Exercises.Helpers;
using _57_Exercises.Models;
using _57_Exercises.ViewModels;

namespace _57_Exercises.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _1()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public ContentResult _1([FromBody] string name)
        {
            if (string.IsNullOrEmpty(name)) return Content("Please enter your name!");
            return Content($"Hello, {name}, nice to meet you!");
        }

        public ActionResult _2()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public ContentResult _2([FromBody] string value)
        {
            if (string.IsNullOrEmpty(value)) return Content("Please enter a string!");

            var length = value.Trim().Length;
            return Content($"\"{value}\" contains {length} characters.");
        }

        public ActionResult _3()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public ContentResult _3([FromBody] string value)
        {
            if (string.IsNullOrEmpty(value)) return Content("Please enter a qoute!");

            var qoute = "The qoute is \""+value+"\".";
            return Content(qoute);
        }

        public ActionResult _4()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public ContentResult _4([FromBody] string value)
        {
            if (value.Length == 0) return Content("Please enter words!");

            var words = JsonConvert.DeserializeObject<List<string>>(value);
            var story = $"Do you {words[1]} your {words[2]} {words[0]} {words[3]}. That is hilarious!";
            return Content(story);
        }

        public ActionResult _5()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public PartialViewResult _5([FromBody] double value1, double value2)
        {
            IEnumerable<string> result = Helper57._5_DoTheMath(value1, value2);
            return PartialView("_5_partial", result);
        }

        public ActionResult _6()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public PartialViewResult _6([FromBody] int age, int retirementAge)
        {
            IEnumerable<string> result = Helper57._6_DoTheMath(age, retirementAge);
            return PartialView("_6_partial", result);
        }

        public ActionResult _7()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public PartialViewResult _7([FromBody] double length, double width, string option)
        {
            Ex7 ex7 = new Ex7(length, width, option);
            double sqFeet = ex7.GetAreaInSquareFeet();
            double sqMeter = ex7.GetAreaInSquareMeter();
            return PartialView("_7_partial", new double[]{sqFeet, sqMeter});
        }

        public ActionResult _8()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public PartialViewResult _8([FromBody] int people, int pizzas, int slicesPerPizza)
        {
            Ex8 ex = new Ex8(people, pizzas, slicesPerPizza);
            int slicesPerPerson = ex.GetSlicesPerPerson();
            int leftOvers = ex.GetLeftOvers();
            return PartialView("_8_partial", new int[] { people, pizzas, slicesPerPerson, leftOvers });
        }

        public ActionResult _9()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public PartialViewResult _9([FromBody] Ex9ViewModel vm)
        {
            Ex9 ex = new Ex9(vm.Width, vm.Length);

            vm.CansOfPaintNeeded = ex.GetPaintNeeded();

            return PartialView("_9_partial", vm);
        }

        public ActionResult _10()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public PartialViewResult _10([FromBody] Ex10ViewModel vm)
        {
            Ex10 ex = new Ex10(vm.ToKeyValuePairs());

            vm.SubTotal = ex.GetSubTotal();
            vm.Tax = ex.GetTax();
            vm.Total = ex.GetTotal();

            return PartialView("_10_partial", vm);
        }

        public ActionResult _12()
        {
            return View(new Ex12ViewModel());
        }

        [System.Web.Mvc.HttpPost]
        public PartialViewResult _12([FromBody] Ex12ViewModel vm)
        {
            Ex12 ex = new Ex12(decimal.Parse(vm.Pricipal), float.Parse(vm.Rate), int.Parse(vm.Years));
            vm.Interest = ex.CalculateInterest().ToString();

            return PartialView("_12_partial", vm);
        }

        public ActionResult _14()
        {
            return View(new Ex14ViewModel());
        }

        [System.Web.Mvc.HttpPost]
        public PartialViewResult _14([FromBody] Ex14ViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction(nameof(_14));
            }
            var amount = decimal.Parse(vm.Amount.Replace(".", ","));

            Ex14 ex = new Ex14(vm.State, amount);
            vm.Result = ex.GetResult();

            return PartialView("_14_partial", vm);
        }

        public ActionResult _15()
        {
            return View(new Ex15ViewModel());
        }

        [System.Web.Mvc.HttpPost]
        public PartialViewResult _15([FromBody] Ex15ViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction(nameof(_15));
            }

            Ex15 ex = new Ex15(vm.Username, vm.Password);
            vm.Result = ex.IsValid()? "Welcome!":"I don't know you.";

            return PartialView("_15_partial", vm);
        }

        public ActionResult _18()
        {
            return View(new Ex18ViewModel());
        }

        [System.Web.Mvc.HttpPost]
        public PartialViewResult _18([FromBody] Ex18ViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction(nameof(_18));
            }

            Ex18 ex = new Ex18(vm.Temperature, (TemeratureScale)Enum.Parse(typeof(TemeratureScale), vm.TempScale));
            vm.TempInFarenheight = ex.GetTempInFarenheight().ToString(CultureInfo.InvariantCulture);
            vm.TempInCelsius = ex.GetTempInCelcius().ToString(CultureInfo.InvariantCulture);

            return PartialView("_18_partial", vm);
        }
    }
}