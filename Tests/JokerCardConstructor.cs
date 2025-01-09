using UnoAdventure.Cards;

namespace Tests;

public class JokerCardConstructor
{
    [Fact]
    public void Test()
    {
        JokerCard card = new JokerCard(4);
        Assert.Equal("Joker4", card.GetCardValue()); // Affiche "Joker4"
    }

    [Fact]
    public void Test2()
    {
        JokerCard card2 = new JokerCard(0); 
        Assert.Equal("Joker0", card2.GetCardValue()); // Affiche "Joker0" 
    }

    [Fact]
    public void Exception()
    {
        Assert.Throws<UnoException>(() => new JokerCard(7));
    }

    [Fact]
    public void Exception_Mod()
    {
        Assert.Throws<UnoException>(() => new JokerCard(10));
    }
}