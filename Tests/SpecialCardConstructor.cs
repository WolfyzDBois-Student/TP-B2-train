using UnoAdventure.Cards;

namespace Tests;

public class SpecialCardConstructor
{
    [Fact]
    public void Test()
    {
        SpecialCard card = new SpecialCard("Reverse", ColorEnum.ColorBlue);
        Assert.Equal("Reverse", card.GetCardValue());
        Assert.Equal("ColorBlue", card.Color.ToString());
    }

    [Fact]
    public void Exception()
    {
        Assert.Throws<UnoException>(() => new SpecialCard("2", ColorEnum.ColorGreen));
    }
}