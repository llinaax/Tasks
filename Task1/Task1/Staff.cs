namespace Task1;

public class Staff
{
    public string Name { get; set; }

    public int Number { get; set; }


    public static Staff CreateEmployee()
    {
        Console.WriteLine("Enter employee's name:");
        var name = Console.ReadLine();
        Console.WriteLine("Enter employee's number:");
        string number = Console.ReadLine();
        bool numbers = int.TryParse(number, out int num);

        return new Staff
        {
            Name = name,
            Number = num
        };
    }
}