namespace Task1;

internal class Orders
{
    public string? Dishes { get; set; }
    public bool Prices { get; set; }
    
    public Orders CreateNewOrder()
    {
        int num;
        Console.WriteLine("Enter the name of the dish:");
        var d = Console.ReadLine();
        Console.WriteLine("Enter the price of the dish:");
        var p = int.TryParse(Console.ReadLine(), out num);
        return new Orders()
        {
            Dishes = d,
            Prices = p
        };
    }
        
}