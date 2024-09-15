
public class Player
{
    //Your magic here
    public string? Name;
    public int HealthPoints = 100;
    public int Power;

    public Player(string? name, int power)
    {
        Name = name;
        Power = power;
    }
    public bool IsAlive() => HealthPoints > 0;
    public void TakeDamage(int damage)
    {
        HealthPoints -= damage;
        if (HealthPoints < 0)
        {
            HealthPoints = 0;
        }
    }
}