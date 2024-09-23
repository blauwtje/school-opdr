class Program
{
    static void Main()
    {
        Console.WriteLine("Give the circle radius:");
        double radius = Convert.ToDouble(Console.ReadLine());
        var circle = new Circle(radius);

        //Print the rounded circle area here
        Console.WriteLine(circle.Area());
    }
}