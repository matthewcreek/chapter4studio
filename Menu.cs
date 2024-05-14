using FoodItems;

namespace Menu;

public class Menu(DateTime updated, List<MenuItem> item)
{
    public DateTime LastUpdated { get; } = updated;
    public List<MenuItem> Items { get; set; } = item;
}