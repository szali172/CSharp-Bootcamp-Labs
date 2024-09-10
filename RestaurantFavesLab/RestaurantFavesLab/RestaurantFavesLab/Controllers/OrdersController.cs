using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantFavesLab.Models;
using RestaurantFavesLab.Data;
using RestaurantFavesLab.Data.Dto;
using Microsoft.IdentityModel.Tokens;

namespace RestaurantFavesLab.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OrdersController : ControllerBase
{
    private readonly RestaurantDbContext _dbContext;

    public OrdersController(RestaurantDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllOrders([FromQuery] string? restaurant, [FromQuery] bool? orderAgain)
    {
        IQueryable<Order> orders = _dbContext.Orders;

        if (!restaurant.IsNullOrEmpty())
        {
            orders = orders.Where(x => x.Restaurant == restaurant);
        }

        if (orderAgain != null)
        {
            orders = orders.Where(x => x.OrderAgain == orderAgain);
        }

        return Ok(await orders.ToListAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetOrderById(int id)
    {
        Order? order = await _dbContext.Orders.FindAsync(id);

        if (order == null)
        {
            return NotFound();
        }

        return Ok(order);
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder([FromBody] CreateOrderDto newOrderDto)
    {
        Order updatedOrder = new Order();

        updatedOrder.Description = newOrderDto.Description;
        updatedOrder.Restaurant = newOrderDto.Restaurant;
        updatedOrder.OrderAgain = newOrderDto.OrderAgain;

        await _dbContext.Orders.AddAsync(updatedOrder);
        await _dbContext.SaveChangesAsync();

        return CreatedAtAction(nameof(GetOrderById), new { id = updatedOrder.Id }, updatedOrder);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateOrder(int id, [FromBody] UpdateOrderDto updateOrderDto)
    {
        Order? order = _dbContext.Orders.Find(id);

        if (order == null)
        {
            return NotFound();
        }

        order.Description = updateOrderDto.Description;
        order.Restaurant = updateOrderDto.Restaurant;
        order.Rating = updateOrderDto.Rating;
        order.OrderAgain = updateOrderDto.OrderAgain;

        _dbContext.Orders.Update(order);
        await _dbContext.SaveChangesAsync();

        return Ok(order);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteOrderById(int id)
    {
        Order? order = await _dbContext.Orders.FindAsync(id);

        if (order == null)
        {
            return NotFound();
        }

        _dbContext.Orders.Remove(order);
        await _dbContext.SaveChangesAsync();

        return NoContent();
    }
}
