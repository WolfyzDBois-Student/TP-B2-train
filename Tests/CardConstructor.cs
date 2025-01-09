namespace Tests;
using UnoAdventure;
using UnoAdventure.Cards;

public class CardConstructor
{
    [Fact]
    public void Return()
    {
        Card card = new Card("7");
        Assert.Equal("7", card.GetCardValue());
        Card card2 = new Card("Reverse");
        Assert.Equal("Reverse", card2.GetCardValue());
    }
}