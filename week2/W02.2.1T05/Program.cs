int passedStudents = 0;
List<double> doubles = new List<double>
        {
            7.0,
            5.5,
            3.2,
            10.0,
            4.5
        };

foreach (double number in doubles)
{
    if (number >= 5.5)
    {
        passedStudents++;
    }
}
Console.WriteLine($"{passedStudents} out of {doubles.Count()} students passed");