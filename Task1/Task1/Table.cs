namespace Task1;

public class Table
{
    public bool Number { get; set; }
   

    public bool Seats { get; set; }
    

    public Table CreateTable()
    {
        int num;
        Console.WriteLine("Enter table Number");
        var number = int.TryParse(Console.ReadLine(), out num);
        Console.WriteLine("Enter table Seats");
        var seats = int.TryParse(Console.ReadLine(), out num);

        return new Table
        {
            Number = number,
            Seats = seats
        };
    }
}