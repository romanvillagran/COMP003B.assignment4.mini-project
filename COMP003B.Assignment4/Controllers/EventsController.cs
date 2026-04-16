using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    [Route("events")]
    public class EventsController : Controller
    {
        [HttpGet("register/{id:int}")]
        public IActionResult Register(int id)
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(Order order)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Confirmation");
            }
            return View(order);
        }
        [HttpGet("confirmation")]
        public IActionResult Confirmation()
        {
            return View();
        }
        
    }
}
