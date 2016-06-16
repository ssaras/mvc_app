using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace mvc_app.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/

        public IActionResult Welcome(string test, string name, int age = 1, int id = 0)
        {
            ViewData["test"] = test;
            ViewData["name"] = name;
            ViewData["age"] = age;
            ViewData["id"] = id;

            return View();            
        }
    }
}