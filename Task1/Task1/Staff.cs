namespace Task1;

public class Staff
{
    public string Name { get; set; }
    public int Number { get; set; }
    
    public Staff CreateEmployee()
    {
        Console.WriteLine("Enter employee's name:");
        var name = Console.ReadLine();
        Console.WriteLine("Enter employee's number:");
        var number = Convert.ToInt32(Console.ReadLine());

        return new Staff
        {
            Name = name,
            Number = number
        };
    }
}