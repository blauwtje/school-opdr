public class Deck
{
    public readonly List<Card> Cards;
    public static readonly string[] Suits = { "Diamonds", "Clubs", "Hearts", "Spades" };
    public static readonly string[] Ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
    public Deck(bool includeJokers)
    {
        Cards = new List<Card>();
        foreach (var suit in Suits)
        {
            foreach (var rank in Ranks)
            {
                Cards.Add(new Card(suit, rank));
            }
        }
        if (includeJokers)
        {
            Cards.Add(new Card("Red", "Joker"));
            Cards.Add(new Card("Black", "Joker"));
            Shuffle();
        }
        else
        {
            Shuffle();
        }
    }
    public void Shuffle()
    {
        Random rng = new Random();
        int n = Cards.Count;
        for (int i = n - 1; i > 0; i--)
        {
            int j = rng.Next(0, i + 1);
            Card temp = Cards[i];
            Cards[i] = Cards[j];
            Cards[j] = temp;
        }
    }

    public Card Draw()
    {
        if (Cards.Count == 0)
        {
            return null!;
        }
        var card = Cards.Last();
        Cards.RemoveAt(Cards.Count - 1);
        return card;
    }
}