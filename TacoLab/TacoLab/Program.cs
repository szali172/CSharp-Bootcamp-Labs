using Microsoft.EntityFrameworkCore;
using TacoLab.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<FastFoodTacoDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("FastFoodTacoDB")));

builder.Services.AddDbContext<FastFoodTacoDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("FastFoodTacoDB"))
           .EnableSensitiveDataLogging()
           .LogTo(Console.WriteLine, LogLevel.Information);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
