namespace Task1;

internal class Orders
{
    public string? Dishes { get; set; }
    public int Prices { get; set; }
    
    public Orders CreateNewOrder()
    {
        Console.WriteLine("Enter the name of the dish:");
        var d = Console.ReadLine();
        Console.WriteLine("Enter the price of the dish:");
        string p = Console.ReadLine();
        var price = int.TryParse(p, out int num);
        return new Orders()
        {
            Dishes = d,
            Prices = num
        };
    }
        
}