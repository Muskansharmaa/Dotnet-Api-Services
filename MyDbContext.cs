namespace FoodApp;

using Microsoft.EntityFrameworkCore;

public class MyDbContext:DbContext{
    public MyDbContext(DbContextOptions<MyDbContext> o):base(o)
    {
        
    }

    public DbSet<FoodItem> fooditems => Set<FoodItem>();
}