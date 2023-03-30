using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class TeamManagement
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public int Task { get; set; }

        public TeamManagement CreateNewEmployee()
        {
            Console.WriteLine("Enter the name of employee:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter the position of employee:");
            var position = Console.ReadLine();
            
            return new TeamManagement()
            {
                Name = name,
                Position = position
            };
        }
    }
}
