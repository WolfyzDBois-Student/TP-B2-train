namespace UnoAdventure.Cards;

public class JokerCard : Card
{
    private ushort _penalty;
    private GameManager _game;
    
    public JokerCard(ushort penalty): base($"Joker{penalty}")
    {
        _penalty = penalty;
        if (penalty > 8 || penalty % 2 == 1)
        {
            throw new UnoException();
        }
    }
    
    public ushort GetPenalty()
    {
        return _penalty;
    }
    
    public ushort SetPenalty(ushort penalty)
    {
        _penalty = penalty;
        Value = $"Joker{penalty}";
        return _penalty;
    }
    
    public void UseCapacity(Player actualPlayer, Queue<Player> players, List<Card> deck)
    {
        Player nextPlayer = players.Dequeue();
        for (int i = 0; i < _penalty; i++)
        {
            nextPlayer.DrawCard(deck);
        }
        players.Enqueue(actualPlayer);
        players.Enqueue(nextPlayer);
    }
}