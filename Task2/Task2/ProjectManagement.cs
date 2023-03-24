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
        List<BeginTerms> _terms = new List<BeginTerms>();
        List<EndTerms> _endTerms = new List<EndTerms>();
        List<Tasks> _tasks = new List<Tasks>();
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
                Console.WriteLine($"Budget: {i.Budget}$");
            }
        }

        public void AddBeginTerm()
        {
            BeginTerms terms = new BeginTerms();
            if (terms.Day > 0 && terms.Day <= 31)
            {
                _terms.Add(terms.CreateDataStart());
            }
            else
            {
                Console.WriteLine("Enter again:");
                _terms.Add(terms.CreateDataStart());
            }
            
            
        }

        public void AddEndTerm()
        {
            EndTerms EndTerms = new EndTerms();
            _endTerms.Add(EndTerms.CreateDataEnd());
        }

        public void PrintBeginTerm()
        {
            foreach (var t in _terms)
            {
                Console.WriteLine($"Your start date: {t.Day}.{t.Month}.{t.Year}");
            }
        }
        public void PrintEndTerm()
        {
            foreach (var t in _endTerms)
            {
                Console.WriteLine($"Your end date: {t.DayEnd}.{t.MonthEnd}.{t.YearEnd}");
            }
        }

        public void AddNewTask()
        {
            Tasks tasks = new Tasks();
            
            Console.Write("How mach tasks would you like to add:");
            var task = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < task; i++)
            {
                _tasks.Add(tasks.CreateNewTask());
            }
            
        }

        public void PrintTasks()
        {
            foreach (var t in _tasks)
            {
                Console.WriteLine("Your added task:");
                Console.WriteLine($"Name: {t.Name}");
                Console.WriteLine($"Assignment: {t.Assignment}");
            }
        }
    }

}
