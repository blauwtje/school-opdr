class CarFactory
{
    public int maxCars;
    public CarFactory(int maxcars)
    {
        maxCars = maxcars;
    }
    public LimitedEditionCar ProduceLimitedEditionCar()
    {
        if (LimitedEditionCar.Counter < maxCars)
            return new LimitedEditionCar();
        return null!;
    }
}