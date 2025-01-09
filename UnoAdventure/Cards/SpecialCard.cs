namespace UnoAdventure.Cards;

public class SpecialCard :Card
{
    public ColorEnum Color;

    public SpecialCard(string cardValue, ColorEnum cardColor) :base(cardValue)
    {
        if (cardValue != "Skip" && cardValue != "PickTwo" && cardValue != "Reverse") throw new UnoException();
        Color = cardColor;
    }
}