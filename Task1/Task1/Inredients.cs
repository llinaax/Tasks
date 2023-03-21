namespace Task1;

public class Inredients
{
    public int Number { get; set; }
        
    public int Seats { get; set; }

    public Table CreateTable()
    {
        Console.WriteLine("Enter table Number");
        var number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter table Seats");
        var seats = Convert.ToInt32(Console.ReadLine());

        return new Table
        {
            Number = number,
            Seats = seats
        };
    }
}