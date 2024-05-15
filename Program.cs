// See https://aka.ms/new-console-template for more information

using FoodItems;
using Menu;

Console.WriteLine("hello papa");

MenuClass papaPizza = new(DateTime.Now, []);

MenuItem pizza = new("Pizza",17.99,"Italian style pizza made with fresh dough and cooked in a wood fire","Dinner",false);
MenuItem pizza2 = new("Pizza",17.99,"Margherita style pizza made with fresh dough and cooked in a wood fire","Dinner",false);
MenuItem italianSalad = new("Salad", 12.99, "Fresh romain lettuce dressed with croutons, provel cheese, and our house-made creamy italian dressing", "Appetizer", false);
MenuItem hotWings = new("10pc Hot Wings", 12.99, "Bone-in wings tossed in our special hot sauce recipe", "Appetizer", true);


papaPizza.AddItem(pizza);
papaPizza.AddItem(pizza2);
papaPizza.AddItem(italianSalad);
papaPizza.AddItem(hotWings);

papaPizza.PrintMenu();

papaPizza.RemoveItem(italianSalad);

papaPizza.DisplayLastUpdated();
papaPizza.PrintMenu();

hotWings.IsItemNew();
pizza.IsItemNew();


Console.WriteLine(hotWings.Equals(pizza));
Console.WriteLine(pizza.Equals(pizza2));


papaPizza.PrintItem(hotWings);

papaPizza.AddItem(hotWings);
papaPizza.PrintMenu();