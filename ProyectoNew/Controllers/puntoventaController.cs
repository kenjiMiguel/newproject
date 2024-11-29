using Microsoft.AspNetCore.Mvc;
using ProyectoNew.Models;

namespace ProyectoNew.Controllers
{
    public class puntoventaController: Controller
    {
        public IActionResult crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult crear(puntoVenta puntoVenta)
        {
            return View();
        }
    }
}
