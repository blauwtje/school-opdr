class Point
{
    public double X;
    public double Y;
    public Point(double x, double y)
    {
        X = x;
        Y = y;
    }
    public static double EuclideanDistance(Point point1, Point point2)
    {
        double x1_x2 = point2.X - point1.X;
        double y1_y2 = point2.Y - point1.Y;
        return Math.Sqrt(x1_x2 * x1_x2 + y1_y2 * y1_y2);
    }
}