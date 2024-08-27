using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TacoLab.Data;
using TacoLab.Models;
using TacoLab.Models.Dto;

namespace TacoLab.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TacosController : ControllerBase
{
    private readonly FastFoodTacoDbContext _fastFoodTacoDb;

    public TacosController(FastFoodTacoDbContext fastFoodDbContext)
    {
        _fastFoodTacoDb = fastFoodDbContext;
    }

    //api/Tacos/softShell
    [HttpGet]
    public IActionResult GetAllTacos([FromQuery] bool? softShell)
    {
        // Get soft shell tacos only
        if (softShell != null && softShell == true)
        {
            List<Taco> softShellTacos = _fastFoodTacoDb.Tacos.Where(x => x.SoftShell == true).ToList();

            return Ok(softShellTacos);
        }

        return Ok(_fastFoodTacoDb.Tacos.ToList());
    }

    //api/Tacos/1
    [HttpGet("{id}")]
    public IActionResult GetTacoById(int id)
    {
        Taco taco = _fastFoodTacoDb.Tacos.Find(id);

        if (taco == null)
        {
            return NotFound();
        }

        return Ok(taco);
    }

    [HttpPost]
    public IActionResult CreateTaco([FromBody] CreateTacoDto tacoDto)
    {
        Taco taco = new Taco();
        taco.Name = tacoDto.Name;
        taco.Cost = tacoDto.Cost;

        _fastFoodTacoDb.Tacos.Add(taco);
        _fastFoodTacoDb.SaveChanges();

        return Created();
    }

    [HttpDelete]
    public IActionResult DeleteTacoById(int id)
    {
        Taco taco = _fastFoodTacoDb.Tacos.Find(id);

        if (taco == null)
        {
            return NotFound();
        }

        _fastFoodTacoDb.Tacos.Remove(taco);
        _fastFoodTacoDb.SaveChanges();

        return NoContent();
    }
}
