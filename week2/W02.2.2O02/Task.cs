class Task
{
    public string Name;
    public bool IsDone;
    public Task(string name)
    {
        Name = name;
    }
    public void Done()
    {
        IsDone = true;
    }
    public string Info()
    {
        if (IsDone)
        {
            return $"Task: {Name}, Status: Done";
        }
        else
        {
            return $"Task: {Name}, Status: Pending";
        }
    }
}