namespace Task1;

public class Ingredients
{
    public string Name { get; set; }

    public int Price { get; set; }
    

    public static Ingredients CreateIngredients()
    {
        Console.WriteLine("Please enter the name of ingredient:");
        var name = Console.ReadLine();
        Console.WriteLine("Please enter a price of ingredient:");
        string p = Console.ReadLine();
        bool price = int.TryParse(p, out int num);

        return new Ingredients()
        {
            Name = name,
            Price = num
        };
    }
    
}