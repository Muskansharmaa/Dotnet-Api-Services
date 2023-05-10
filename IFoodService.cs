using FoodApp;

public interface IFoodService{
    Task<int> AddFoodItem(FoodItem foodItem);
}