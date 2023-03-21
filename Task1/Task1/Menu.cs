namespace Task1;

public class Menu
{
    public string Dish { get; set; }
        
    public int Price { get; set; }
    
    public string Inredients { get; set; }
    
    public Menu CreateDish()
    {
        Console.WriteLine("Enter tha name of the dish:");
        var dish = Console.ReadLine();
        Console.WriteLine("Enter the price of the dish:");
        var price = Convert.ToInt32(Console.ReadLine());
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