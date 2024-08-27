using Microsoft.AspNetCore.Mvc;
using AdoptionMVC.Models;
using AdoptionMVC.Data;

namespace AdoptionMVC.Controllers
{
    public class AnimalController : Controller
    {
        private readonly AppDbContext _dbContext;

        public AnimalController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult SearchAnimals(string breedInput)
        {
            //SELECT * FROM Animals WHERE Breed = breedInput
            var animals = _dbContext.Animals.Where(x => x.Breed == breedInput).ToList();
            return View(animals);
        }
    }
}
