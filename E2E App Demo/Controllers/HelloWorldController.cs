using Microsoft.AspNetCore.Mvc;

namespace E2E_App_Demo.Controllers
{
	public class HelloWorldController : Controller
	{
        //
        //GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //
        //GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
