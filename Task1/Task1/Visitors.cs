namespace Task1;

public class Visitors
{
    public string Name { get; set; }
    public bool Number { get; set; }


    public Visitors CreateVisitor()
    {
        int num;
        Console.WriteLine("Enter your name:");
        var name = Console.ReadLine();
        Console.WriteLine("Enter your number:");
        var number = int.TryParse(Console.ReadLine(), out num);

    return new Visitors
        {
            Name = name,
            Number = number
        };
    }
}