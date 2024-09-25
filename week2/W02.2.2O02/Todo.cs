class Todo
{
    public List<Task> TaskList;
    public Todo()
    {
        TaskList = new List<Task>();
    }
    public void Task(string name)
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
        return null;
    }
    public string Report()
    {
        foreach (Task task in TaskList)
        {
            Console.WriteLine(task);
        }
    }
}