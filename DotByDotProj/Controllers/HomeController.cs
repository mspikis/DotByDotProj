using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

<<<<<<< HEAD
namespace DotByDotProj.Controllers
=======
namespace MvcMovie.Controllers
>>>>>>> master
{
    public class HomeController : Controller
    {
        // 
        // GET: /HelloWorld/

<<<<<<< HEAD
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
=======
        public string Index()
        {
            return "This is my default action...";
        }

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
>>>>>>> master
        }
    }
}
