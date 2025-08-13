using Restaurants.Domain.Entities;

public interface IDishesRepository
{
    Task<int> Create(Dish entity);
    Task Delete(IEnumerable<Dish> entities);
}