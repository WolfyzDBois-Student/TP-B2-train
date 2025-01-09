namespace UnoAdventure.Cards;

public class Card
{
    protected string Value;

    public Card(string cardValue)
    {
        Value = cardValue;
    }
    
    public string GetCardValue()
    {
        return Value;
    }
}
