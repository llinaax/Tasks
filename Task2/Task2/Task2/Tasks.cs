namespace Task2;

internal class Tasks
{
    public string Name { get; set; }
    public string Description { get; set; }

    public Tasks CreateTasks()
    {
        Console.WriteLine("How much tasks would you like to add:");
       
        Console.WriteLine("Enter the name of project:");
        var name = Console.ReadLine();

        Console.WriteLine("Enter the description of project:");
        var description = Console.ReadLine();
        

        return new Tasks()
        {
            Name = name,
            Description = description,

        };
    }
}