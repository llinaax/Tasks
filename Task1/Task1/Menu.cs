namespace Task1;

public class Menu
{
    public string Dish { get; set; }
        
    public string Price { get; set; }
    
    public string Inredients { get; set; }

    

    public Menu CreateDish()
    {
        
        Console.WriteLine("Enter tha name of the dish:");
        var dish = Console.ReadLine();
        Console.WriteLine("Enter the price of the dish:");
        string price = Console.ReadLine();
        bool p = Int32.TryParse(price, out int i);
        Console.WriteLine("Enter the ingredients:");
        var inredients = Console.ReadLine();

        return new Menu()
        {
            Dish = dish,
            Price  = price,
            Inredients = inredients
        };
    }
}