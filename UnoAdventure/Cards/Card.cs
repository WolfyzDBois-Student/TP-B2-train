namespace UnoAdventure.Cards;

public class Card
{
    private string Value;

    public Card(string cardValue)
    {
        Value = cardValue;
    }

    public string GetCardValue()
    {
        return Value;
    }
}