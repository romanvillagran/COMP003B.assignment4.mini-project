using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
namespace COMP003B.Assignment4.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            return View(order);
        }

        [HttpGet]
        public IActionResult Success()
        {
            return View();
        }
    }
}
