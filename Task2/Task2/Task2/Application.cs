using System.Threading.Channels;

namespace Task2;

internal class Application
{

    private List<string> Actions = new List<string>()
    {
        "*Actions on program*\n",
        "Add new project press: '1'",
        "Add new task press: '2'",
        "Edit project press: '3'",
        "Edit tasks press: '4'",
        "Add new employee press: '5'",
        "To exit of program press: '0'"
    };
    
    public void PrintActions()
    {
        foreach (var a in Actions)
        {

            Console.WriteLine(a);
        }
    }

   

    public void Buttons()
    {
        bool i = true;
        while (i)
        {
            ManagementProgram managementProgram = new ManagementProgram();
            Console.Write("Press the button that you need:");
            string ask = Console.ReadLine();
           
            bool ask1 = int.TryParse(ask, out int num);

            switch (num)
            {
                case 1:
                    managementProgram.AddProject();
                    break;
                case 2:
                    managementProgram.AddTask();
                    break;
                case 0:
                    i = false;
                    break;
                    
            }
        }
    }
}