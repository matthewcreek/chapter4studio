using System.ComponentModel;

namespace FoodItems;

public class MenuItem(string name, double price, string description, string category, bool isNew)
{
    public string Name { get; set; } = name;
    public double Price { get; set; } = price;
    public string Description { get; set; } = description;
    public string Category { get; set; } = category;
    public bool IsNew { get; set; } = isNew;

    public void IsItemNew()
    {
        if (IsNew)
        {
            Console.WriteLine($"{Name} is new!");
        }
        else
        {
            Console.WriteLine($"{Name} is not new.");
        }
    }

    public override bool Equals(object? obj)
    {
        return obj is MenuItem item &&
               Name == item.Name &&
               Category == item.Category;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Category);
    }
}