﻿namespace Task1;

public class Staff
{
    public string Name { get; set; }

    public int Number { get; set; }


    public Staff CreateEmployee()
    {
        Console.WriteLine("Enter employee's name:");
        var name = Console.ReadLine();
        Console.WriteLine("Enter employee's number:");
        srting number = Console.ReadLine()
        bool numbers = int.TryParse(number, out int num);

        return new Staff
        {
            Name = name,
            Number = num
        };
    }
}