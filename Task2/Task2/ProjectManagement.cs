using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class ProjectManagement
    {
        List<Projects> _projects = new List<Projects>();
        public void AddNewProject()
        {
            Projects projects = new Projects();
            _projects.Add(projects.CreateProject());
        }

        public void PrintProject()
        {
            foreach (var i in _projects)
            {
                Console.WriteLine("Your added project\n");
                Console.WriteLine($"Name: {i.Name}");
                Console.WriteLine($"Description: {i.Description}");
                Console.WriteLine($"Begin: {i.StartTermsDay}");
                Console.WriteLine($"The end: {i.EndTermsDay}");
                Console.WriteLine($"Budget: {i.Budget}$");
            }
        }
    }
}
