public class DayOfWeek
{
    private int _index;
    public int Index
    {
        get { return _index; }
        set { _index = (value % 7 + 7) % 7; }
    }
    public DayOfWeek(int index)
    {
        Index = index;
    }
    public static string IndexToDay(int Index)
    {
        Index = (Index % 7 + 7) % 7;
        string result = Index switch
        {
            0 => "Monday",
            1 => "Tuesday",
            2 => "Wednesday",
            3 => "Thursday",
            4 => "Friday",
            5 => "Saturday",
            6 => "Sunday",
            _ => "Invalid day"

        };
        return result;
    }
    public bool IsWeekend()
    {
        return Index == 5 || Index == 6;
    }
    public string CurrentDay()
    {
        return IndexToDay(Index);
    }
    public void NextDay()
    {
        Index++;
    }
}