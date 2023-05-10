using FoodApp;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IFoodService, FoodService>();
builder.Services.AddDbContext<MyDbContext>(o => o.UseSqlite("Data Source = Food.db"));
var app = builder.Build();

app.MapGet("/fooditems", (MyDbContext db) => db.fooditems.ToList());
app.MapGet("/fooditems/{id}", ([FromRoute]int id ,MyDbContext db) => db.fooditems.Select(x => x.id == id).ToList());

app.MapPost("/fooditems", async ([FromBody]FoodItem f, IFoodService fs) => {
    var result = await fs.AddFoodItem(f);
    return Results.Ok(result);
});

app.Run();
