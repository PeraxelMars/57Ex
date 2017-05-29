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
            //if (string.IsNullOrEmpty(values))
            //    return Content("Invalid data!");

           //var numbers = JsonConvert.DeserializeObject<List<Int64>>(value);

            var sum = data.Values.Sum();

            return Content(sum.ToString());
        }
    }

    public class Ex28ViewModel
    {
        public int[] Values { get; set; }
    }
}