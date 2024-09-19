class Button
{
    public bool IsPressed = false;
    public int TimesPressed = 0;
    public void Press()
    {
        IsPressed = !IsPressed;
        TimesPressed++;
    }
    public string Info()
    {
        return $"Button is {(IsPressed ? "pressed" : "not pressed")}.\nPressed {TimesPressed} times.";
    }
}