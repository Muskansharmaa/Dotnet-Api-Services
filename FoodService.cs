using FoodApp;

public class FoodService : IFoodService
{

    public readonly MyDbContext _db;
    public FoodService(MyDbContext db)
    {
        _db = db;
    }

    public async Task<int> AddFoodItem(FoodItem foodItem)
    {
         _db.fooditems.Add(foodItem);
         return await _db.SaveChangesAsync();

    }
}