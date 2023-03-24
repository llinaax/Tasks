using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Application
    {
        List<string> Actions = new List<string>()
        {
            "Actions\n",
            "1.Create a new project: '1'",
            "2.Adding tasks: '2'",
            "3.Edit project: '3'",
            "4.Team Management: '4'\n"
        };

        public void PrintActions()
        {
            foreach (var a in Actions)
            {
                Console.WriteLine(a);
            }
        }

        public void ChooseAnAction()
        {
            ProjectManagement projectManagement = new ProjectManagement();
            BeginTerms beginTerms = new BeginTerms();
            EndTerms ensTerms = new EndTerms();
            var i = true;
            while (i)
            {
                Console.WriteLine("Press the button that you need:");
                var ask = Convert.ToInt32(Console.ReadLine());

                switch (ask)
                {
                    case 1:
                        projectManagement.AddNewProject();
                        projectManagement.AddBeginTerm();
                        projectManagement.AddEndTerm();
                        projectManagement.PrintProject();
                        projectManagement.PrintBeginTerm();
                        projectManagement.PrintEndTerm();
                        break;
                    case 2:
                        projectManagement.AddNewTask();
                        projectManagement.PrintTasks();
                        break;
                    case 5:
                        i = false;
                        break;
                }
            }
        }

    }
}
