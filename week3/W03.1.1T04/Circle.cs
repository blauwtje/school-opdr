class Circle
{
    public double Radius;
    public Circle(double radius)
    {
        Radius = radius;
    }
    public double Area() => Math.Round(Math.PI * Math.Pow(Radius, 2));
}