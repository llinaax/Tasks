namespace Task1;

public class Inredients
{
    public string Name { get; set; }
    public int Price { get; set; }
    
    public Inredients CreateIngredients()
    {
        Console.WriteLine("Please enter the name of ingredient:");
        var name = Console.ReadLine();
        Console.WriteLine("Please enter a price of ingredient:");
        var price = Convert.ToInt32(Console.ReadLine());

        return new Inredients()
        {
            Name = name,
            Price = price
        };
    }
}