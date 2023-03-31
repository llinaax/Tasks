namespace Task1;

public class Menu
{
    public string Dish { get; set; }
        
    public int Price { get; set; }
    
    public string Inredients { get; set; }

    private Menu()
    {
        
    }
    public static Menu CreateDish()
    {
        
        Console.WriteLine("Enter tha name of the dish:");
        var dish = Console.ReadLine();
        Console.WriteLine("Enter the price of the dish:");
        string price = Console.ReadLine();
        bool p = int.TryParse(price, out int i);
        Console.WriteLine("Enter the ingredients:");
        var inredients = Console.ReadLine();

        return new Menu()
        {
            Dish = dish,
            Price  = i,
            Inredients = inredients
        };
    }
}