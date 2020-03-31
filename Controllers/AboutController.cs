using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    public class AboutController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //List<String> Language = new List<string>();
            //Language.Add("Python");
            //Language.Add("CSharp");
            //Language.Add("Java");
            //Language.Add("C++");
            //Language.Add("JavaScript");
            //Language.Add("jQuery");
            string language = "Hello I am python developer";

            ViewBag.language = language;
            return View();
        }

        public ActionResult GetData()
        {
            //string result = "This is about Page";
            //string result = "https://www.google.com/";
            //return Content(result, "text/plain");
            //return Redirect(result);
            // Redirecting to same controller

            return RedirectToAction("Index", "Home");
        }
    }
}
