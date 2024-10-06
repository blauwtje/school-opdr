static class GameTools
{
    public static bool ReturnCount = true;
    public static string CoinFlip(int flipAmount)
    {
        Random random = new();
        string sequence = "";
        if (ReturnCount == false)
        {
            for (int i = 0; i < flipAmount; i++)
            {
                sequence += random.Next(0, 2) == 0 ? "Heads" : "Tails";
                if (i < flipAmount - 1)
                {
                    sequence += "\n";
                }
            }
        }
        else
        {
            int headsCount = 0;
            int tailsCount = 0;
            for (int i = 0; i < flipAmount; i++)
            {
                if (random.Next(0, 2) == 0)
                {
                    headsCount++;
                }
                else
                {
                    tailsCount++;
                }
            }
            sequence += $"Heads: {headsCount}\nTails: {tailsCount}";
        }
        return sequence;
    }
    public static string DiceRoll(int dieSides, int rollAmount)
    {
        if (dieSides < 3)
        {
            return "Invalid number of die sides";
        }
        List<int> diceList = new List<int>(new int[dieSides]);
        Random random = new();
        string sequence = "";
        if (ReturnCount == false)
        {
            for (int i = 0; i < rollAmount; i++)
            {
                int diceRoll = random.Next(1, 7);
                sequence += $"Roll {i + 1}: {diceRoll}";
                if (i < rollAmount - 1)
                {
                    sequence += "\n";
                }
            }
            return sequence;
        }
        else
        {
            for (int i = 0; i < rollAmount; i++)
            {
                int diceRoll = random.Next(1, 7);
                diceList[diceRoll - 1]++;
            }
            for (int i = 0; i < diceList.Count; i++)
            {
                sequence += $"{i + 1} was rolled {diceList[i]} times";
                if (i < diceList.Count - 1)
                {
                    sequence += "\n";
                }
            }
            return sequence;
        }
    }
}