namespace Task1;

public class Ingredients
{
    public string Name { get; set; }

    public bool Price { get; set; }
    

    public static Ingredients CreateIngredients()
    {
        int num;
        Console.WriteLine("Please enter the name of ingredient:");
        var name = Console.ReadLine();
        Console.WriteLine("Please enter a price of ingredient:");
        bool price = int.TryParse(Console.ReadLine(), out num);

        return new Ingredients()
        {
            Name = name,
            Price = price
        };
    }
}