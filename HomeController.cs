using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcautomaticCrud.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult Calculat()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Calculat(string firstNumber, string secondNumber, string Cal)
        {
            int a = int.Parse(firstNumber);
            int b = int.Parse(secondNumber);
            int c = 0;
            switch (Cal)
            {
                case "Add":
                    c = a + b;
                    break;
                case "Sub":
                    c = a - b;
                    break;
                case "Mul":
                    c = a * b;
                    break;
                case "Div":
                    c = a / b;
                    break;
            }
            ViewBag.Result = c;
            return View();
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}