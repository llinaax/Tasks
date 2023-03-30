using System.Net.Mime;

namespace Task2;

internal class ManagementProgram
{
    List<Projects> _projects = new List<Projects>();
    List<Tasks> _tasks = new List<Tasks>();
    public void AddProject()
    {
        Projects projects = new Projects();
        _projects.Add(projects.CreateProject());
    }

    public void AddTask()
    {
        Tasks tasks = new Tasks();
        _tasks.Add(tasks.CreateTasks());
    }
}
