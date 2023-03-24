using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Projects
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string StartTermsDay { get; set; }
        public string EndTermsDay { get; set; }
        public int Budget { get; set; }

        public Projects CreateProject()
        {
            Console.WriteLine("Enter the name of project:");
            var name = Console.ReadLine();
            Console.WriteLine("Enter the description of project:");
            var description = Console.ReadLine();
            Console.WriteLine("Enter project design start:");
            string startTermsDay = Console.ReadLine();
            Console.WriteLine("Enter the end of project design:");
            string endTermsDay = Console.ReadLine();
            Console.WriteLine("Enter the budget of project:");
            int budget = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("__________________");

            return new Projects()
            {
                Name = name,
                Description = description,
                StartTermsDay = startTermsDay,
                EndTermsDay = endTermsDay,
                Budget = budget
            };
        }
    }
}
