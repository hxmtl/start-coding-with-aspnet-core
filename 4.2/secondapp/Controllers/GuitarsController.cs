using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using secondapp.Data;

namespace secondapp.Controllers
{
    public class GuitarsController : Controller
    {
        private readonly StaticGuitarRepository _repo = new StaticGuitarRepository();
        public IActionResult Index()
        {
            var guitars = _repo.All();

            return View(guitars);
        }

        //[Route("products/guitars/{id}")]
        public IActionResult SingleProduct(int id) {
            var guitar = _repo.Get(id);

            if (guitar == null) {
                return NotFound();
            }

            return View(guitar);
        }

        public string Edit(int id)
        {
            return $"Guitar ID: {id}";
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
