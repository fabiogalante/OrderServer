using Microsoft.AspNetCore.Mvc;

namespace OrderPublisher.Controllers
{
    public class Order : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}