class Game
{
    public Player Player1;
    public Player Player2;
    public Game(Player player1, Player player2)
    {
        Player1 = player1;
        Player2 = player2;
    }
    public Player Round1()
    {
        if (Player1.Skill == Player2.Skill)
        {
            return Player1;
        }
        return Player1.Skill > Player2.Skill ? Player1 : Player2;
    }
    public Player Round2()
    {
        if (Player1.Intelligence == Player2.Intelligence)
        {
            return Player1;
        }
        return Player1.Intelligence > Player2.Intelligence ? Player1 : Player2;
    }
    public Player Round3()
    {
        if (Player1.Knowledge == Player2.Knowledge)
        {
            return Player1;
        }
        return Player1.Knowledge > Player2.Knowledge ? Player1 : Player2;
    }
    public static string Instructions()
    {
        return "Win at least 2 rounds to win!";
    }
}