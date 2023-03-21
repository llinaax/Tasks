namespace Task1;

public class RestaurantManagment
{
    List<string> Instructions = new List<string>()
    {
        "1. For adding new dish press : 1",
        "2. For adding new ingredient press : 2",
        "3. For adding new order press : 3",
        "4. For adding new employee press : 4",
        "5. For adding new visitor press : 5",
        "6. For adding new table press : 6",
        "7. To view added visitors: 7",
        "8. To view added employees: 8\n",
        "9. To stop doing any actions: 9",
    };

    public void PrintInstructions()
    {
        foreach (var i in Instructions)
        {
            Console.WriteLine(i);
        }
    }

    List<Menu> Menus = new List<Menu>();
    public void AddNewDish()
    {
        Menu menu = new Menu();
        Menus.Add(menu.CreateDish());
    }

    public void PrintMenu()
    {
        foreach (var m in Menus)
        {
            Console.WriteLine($"Added dish: {m.Dish}");
            Console.WriteLine($"Added price: {m.Price}");
        }
    }
    

}