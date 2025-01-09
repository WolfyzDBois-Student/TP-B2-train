using UnoAdventure.Cards;

namespace Tests;

public class BasicCardConstructor
{
    [Fact]
    public void Test()
    {
        BasicCard card = new BasicCard("7", ColorEnum.ColorRed);
        Assert.Equal("7", card.GetCardValue());
        Assert.Equal("ColorRed", card.Color.ToString());
    }

    [Fact]
    public void Exception()
    {
        Assert.Throws<UnoException>(() => new BasicCard("Reverse", ColorEnum.ColorRed));
    }
}