namespace Task1;

public class Table
{
    public int Number { get; set; }
    public int Seats { get; set; }

    private Table()
    {
        
    }
    public static Table CreateTable()
    {
        Console.WriteLine("Enter table Number");
        string num = Console.ReadLine();
        bool number = int.TryParse(num, out int n);
        Console.WriteLine("Enter table Seats");
        string seat = Console.ReadLine();
        bool seats = int.TryParse(seat, out int s);

        return new Table
        {
            Number = n,
            Seats = s
        };
    }
}