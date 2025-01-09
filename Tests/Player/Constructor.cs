namespace Tests.Player;

public class Constructor
{
    [Fact]
    public void Test()
    {
        UnoAdventure.Player player = new UnoAdventure.Player("Alice");
        Assert.Equal("Alice", player.Name); // Affiche "Alice"
        Assert.Equal(0, player.NbCards); // Affiche 0
    }
}