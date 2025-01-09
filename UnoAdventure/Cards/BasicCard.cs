namespace UnoAdventure.Cards;

public class BasicCard : Card
{
    public ColorEnum Color;

    public BasicCard(string cardValue, ColorEnum cardColor) : base(cardValue)
    {
        if (cardValue.Length > 1 || cardValue[0] < '0' || cardValue[0] > '9')
        {
            throw new UnoException();
        }
        
        Color = cardColor;
    }
}