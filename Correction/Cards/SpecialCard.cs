using System.Net.NetworkInformation;

namespace UnoAdventure.Cards;

public class SpecialCard : Card
{
    public ColorEnum Color;

    /// <summary>
    /// For a special card, the value must be "PickTwo", "Reverse" or "Skip".
    /// </summary>
    public SpecialCard(string value, ColorEnum color) : base(value)
    {
        Color = color;
        switch (value)
        {
            case "PickTwo":
            case "Reverse":
            case "Skip":
                break;
            default:
                throw new UnoException();
        }
    }
    
    public void PickTwoCard(Player actualPlayer, Queue<Player> players, List<Card> deck)
    {
        Player nextPlayer = players.Dequeue();
        for (int i = 0; i < 2; i++)
        {
            nextPlayer.DrawCard(deck);
        }
        players.Enqueue(actualPlayer);
        players.Enqueue(nextPlayer);
    }
    
    public void SkipCard(Player actualPlayer, Queue<Player> players)
    {
        players.Enqueue(actualPlayer);
        players.Enqueue(players.Dequeue());
    }
    
    public void ReverseCard(Player actualPlayer, Queue<Player> players)
    {
        Player[] playersArray = new Player[players.Count];
        
        for (int i = 0; i < playersArray.Length; i++)
            playersArray[i] = players.Dequeue();
        
        for (int i = playersArray.Length - 1; i >= 0; i--)
            players.Enqueue(playersArray[i]);
        
        players.Enqueue(actualPlayer);
    }
    
    public void UseCapacity(Player actualPlayer, Queue<Player> players, List<Card> deck)
    {
        switch (Value)
        {
            case "PickTwo":
                PickTwoCard(actualPlayer, players, deck);
                break;
            case "Reverse":
                ReverseCard(actualPlayer, players);
                break;
            case "Skip":
                SkipCard(actualPlayer, players);
                break;
        }
    }
}