using FoodItems;

namespace Menu;

public class MenuClass(DateTime updated, List<MenuItem> items)
{
    public DateTime LastUpdated { get; } = updated;
    public List<MenuItem> Items { get; set; } = items;

    public void AddItem(MenuItem item)
    {
        for (int i = 0; i < Items.Count; i++)
        {
            if (Items[i].Equals(item)){
                Console.WriteLine($"{item.Name} is already on the menu.");
                return;
            }
        }
        Items.Add(item);
    }

    public void RemoveItem(MenuItem item)
    {
        Items.Remove(item);
    }

    public void DisplayLastUpdated()
    {
        Console.WriteLine($"Menu updated last: {LastUpdated}");
    }

    public void PrintItem(MenuItem item)
    {
        Console.WriteLine($"{item.Name}: {item.Description} --- ${item.Price}");
    }

    public void PrintMenu() {
        Console.WriteLine("Welcome to Papa's Pizzeria");
        foreach(MenuItem item in Items)
        {
            Console.WriteLine($"{item.Name}:\t{item.Description} --- ${item.Price}");
        }
        Console.WriteLine(Environment.NewLine);
    }
}