using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using _57_Exercises.Models;
using _57_Exercises.ViewModels;

namespace _57_Exercises.Controllers
{
    public class Chapter7Controller : Controller
    {
        [HttpGet]
        public ActionResult _33()
        {
            return View();
        }

        [System.Web.Mvc.HttpPost]
        public PartialViewResult _33(string question)
        {
            string answer = Ex33.GetAnswer();
            return PartialView("_33_partial", answer);
        }

        [HttpGet]
        public ActionResult _34()
        {
            Ex34ViewModel vm = new Ex34ViewModel();
            IEnumerable<string> entityModel = Ex34.GetNames();

            vm.MapFromDomain(entityModel);
            return View(vm);
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult _34(string name)
        {
            Ex34.RemoveName(name);

            return RedirectToAction(nameof(_34));
        }
    }
}