namespace Task1;

public class Staff
{
    public string Name { get; set; }

    public bool Number { get; set; }


    public Staff CreateEmployee()
    {
        int num;
        Console.WriteLine("Enter employee's name:");
        var name = Console.ReadLine();
        Console.WriteLine("Enter employee's number:");
        var number = int.TryParse(Console.ReadLine(), out num);

        return new Staff
        {
            Name = name,
            Number = number
        };
    }
}