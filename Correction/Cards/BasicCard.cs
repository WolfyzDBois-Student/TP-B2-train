namespace UnoAdventure.Cards;

public class BasicCard : Card
{
    public ColorEnum Color;

    /// <summary>
    /// For a basic card, the value must be a number between 0 and 9.
    /// </summary>
    public BasicCard(string cardValue, ColorEnum cardColor) : base(cardValue)
    {
        if (cardValue.Length != 1 || cardValue[0] < '0' || cardValue[0] > '9')
        {
            throw new UnoException();
        }
        Color = cardColor;
    }
}
