using CoffeeShopRegistration.Models;
using CoffeeShopRegistration.Models.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeShopRegistration.Controllers;

public class UserController : Controller
{
    //Dependency Injection
    private AppDbContext _dbContext;

    public UserController(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Register()
    {
        return View();
    }

    //Post means from the browser or client to the controller
    [HttpPost]
    public IActionResult RegisterUser(User user)
    {
        _dbContext.AddAsync(user);
        _dbContext.SaveChanges();

        return RedirectToAction("Index", "Home");
    }
}
