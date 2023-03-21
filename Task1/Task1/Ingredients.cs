namespace Task1;

public class Ingredients
{
    public string Name { get; set; }
    public int Price { get; set; }
    
    public Ingredients CreateIngredients()
    {
        Console.WriteLine("Please enter the name of ingredient:");
        var name = Console.ReadLine();
        Console.WriteLine("Please enter a price of ingredient:");
        var price = Convert.ToInt32(Console.ReadLine());

        return new Ingredients()
        {
            Name = name,
            Price = price
        };
    }
}