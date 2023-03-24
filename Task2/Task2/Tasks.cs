using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Tasks
    {
        public string Name { get; set; }
        public string Assignment { get; set; }

        public Tasks CreateNewTask()
        {
            Console.WriteLine("Enter the name of task:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter an assignment of task:");
            var assignment = Console.ReadLine();

            return new Tasks()
            {
                Name = name,
                Assignment = assignment
            };
        }
    }
}
