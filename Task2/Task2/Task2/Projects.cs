namespace Task2;

internal class Projects
{
    public string Name { get; set; }
    public string StartTerm { get; set; }
    public string EndTerm { get; set; }
    public string Description { get; set; }

    public Projects CreateProject()
    {
        Console.WriteLine("Enter the name of project:");
        var name = Console.ReadLine();
        Console.WriteLine("Enter start date of project(dd.mm.yyyy);");
        DateTime start = DateTime.Parse(Console.ReadLine()); 
        string startTerm = start.ToString("MM/dd/yyyy");
        Console.WriteLine("Enter end date of project(dd.mm.yyyy);");
        DateTime end = DateTime.Parse(Console.ReadLine());
        string endTerm = start.ToString("MM/dd/yyyy");
        Console.WriteLine("Enter the description of project:");
        var description = Console.ReadLine();

        return new Projects()
        {
            Name = name,
            Description = description,
            StartTerm = startTerm,
            EndTerm = endTerm
        };

    }
}