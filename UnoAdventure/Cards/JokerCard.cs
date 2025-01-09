namespace UnoAdventure.Cards;

public class JokerCard :Card
{
    private ushort _penalty;

    public JokerCard(ushort penalty) :base($"Joker{penalty}")
    {
        if (penalty % 2 != 0 || penalty > 8) throw new UnoException();
        _penalty = penalty;
    }
}