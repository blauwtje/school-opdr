class Player
{
    public string Name;
    public int Points;
    public int Skill;
    public int Intelligence;
    public int Knowledge;
    public Player(string name, int skill, int intelligence, int knowledge)
    {
        Name = name;
        Skill = skill;
        Intelligence = intelligence;
        Knowledge = knowledge;
    }
    public void Score()
    {
        Points++;
    }
    public static Player WhoIsWinning(Player player1, Player player2)
    {
        if (player1.Points == player2.Points)
        {
            return null!;
        }
        return player1.Points > player2.Points ? player1 : player2;
    }
}