class Todo
{
    public List<Task> TaskList;
    public Todo()
    {
        TaskList = new List<Task>();
    }
    public void AddTask(string name)
    {
        TaskList.Add(new Task(name));
    }
    public Task GetTask(string name)
    {
        foreach (Task task in TaskList)
        {
            if (task.Name == name)
            {
                return task;
            }
        }
        return null!;
    }
    public string Report()
    {
        string report = "";
        foreach (Task task in TaskList)
        {
            report += task.Info() + "\n";
        }
        return report;
    }
}