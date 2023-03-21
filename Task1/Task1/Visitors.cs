namespace Task1;

public class Visitors
{
    public string Name { get; set; }
    public int Number { get; set; }
    
    public Visitors CreateVisitor()
    {
        Console.WriteLine("Enter your name:");
        var name = Console.ReadLine();
        Console.WriteLine("Enter your number:");
        var number = Convert.ToInt32(Console.ReadLine());

        return new Visitors
        {
            Name = name,
            Number = number
        };
    }
}