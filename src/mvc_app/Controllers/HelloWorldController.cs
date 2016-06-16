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

        public string Welcome(string test, string name, int age = 1, int id = 0)
        {
            return HtmlEncoder.Default.Encode(
                "Name: " + name + "; Age: " + age + "; ID: " + id + "; test: " + test);
            
        }
    }
}