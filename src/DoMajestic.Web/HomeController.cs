using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DoMajestic.Web
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.Title = "DoMajestic Home Page";
            return View();
        }

        public IActionResult Services()
        {
            ViewBag.Title = "Services";
            return View();
        }

        public IActionResult Contacts()
        {
            ViewBag.Title = "Contacts";
            return View();
        }

        public IActionResult Gallery()
        {
            ViewBag.Title = "Gallery";
            return View();
        }
    }
}
