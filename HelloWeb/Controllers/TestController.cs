using Microsoft.AspNetCore.Mvc;

namespace HelloWeb.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Hello()
        {
            return View();
        }

        public IActionResult Print(int limit)
        {
            return View(limit);
        }
        public IActionResult Table5()
        {
            return View();
        }
        public IActionResult Multiply5(int multiple)
        {
            return View(multiple);
        }
        public IActionResult Integer()
        {
            return View();
        }
    }
}
