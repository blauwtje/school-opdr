class Scale
{
    public bool UseKg = true;
    public static double ConvertKgToLbs(double kg) => kg * 2.2;
    public string DisplayWeight(double weight)
    {
        if (UseKg == true)
        {
            return $"{weight} kg";
        }
        else
        {
            return $"{ConvertKgToLbs(weight)} lbs";
        }
    }
}