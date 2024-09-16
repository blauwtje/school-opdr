class Person
{
    public string Name;
    public Job? DayJob;
    public Person(string name, Job job)
    {
        Name = name;
        DayJob = job;
    }
    public string Info()
    {
        if (DayJob != null)
        {
            return $"{Name} works as a {DayJob.Name}";
        }
        else
        {
            return $"{Name} is in between jobs";
        }
    }
}