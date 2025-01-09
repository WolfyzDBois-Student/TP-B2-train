using UnoAdventure.Cards;

namespace UnoAdventure;

public class GameManager
{
    public Queue<Player> Players { get; private set; }
    public List<Card> Deck { get; set; }
    public Stack<Card> DiscardPile { get; private set; }

    public GameManager()
    {
        Players = new Queue<Player>();
        Deck = new List<Card>();
        DiscardPile = new Stack<Card>();
    }
    
    public void AddPlayer(Player player)
    {
        Players.Enqueue(player);
    }
    
    public void AddPlayers(Player[] players)
    {
        foreach (var player in players)
        {
            Players.Enqueue(player);
        }
    }

    public void CreateDeck()
    {
        for (int i = 0; i < 2; i++)
        {
            foreach (ColorEnum color in Enum.GetValues(typeof(ColorEnum)))
            {
                for (int j = 0; j < 10; j++)
                {
                    Deck.Add(new BasicCard(j.ToString(), color));
                }

                Deck.Add(new SpecialCard("PickTwo", color));
                Deck.Add(new SpecialCard("Skip", color));
                Deck.Add(new SpecialCard("Reverse", color));
            }
            Deck.Add(new JokerCard(0));
            Deck.Add(new JokerCard(4));
            Deck.Add(new JokerCard(8));
        }
    }

    public void ShuffleDeck()
    {
        int deckSize = Deck.Count;
        int numberOfRows = deckSize / 5;
        if (deckSize % 5 != 0)
            numberOfRows++;
        
        var shuffledDeck = new Card?[5][];
        for (int i = 0; i < numberOfRows; i++)
            shuffledDeck[i] = new Card?[5] {null, null, null, null, null};
        
        for (int i = 0; i < deckSize; i++)
        {
            shuffledDeck[i % numberOfRows][i / numberOfRows] = Deck[i];
        }
        
        Deck = new List<Card>();
        for (int i = 0; i < numberOfRows; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (shuffledDeck[i][j] is not null)
                    Deck.Add(shuffledDeck[i][j]!);
            }
        }
    }
    
    public Dictionary<Player,int> CountPoints()
    {
        var pointsPerPlayer = new Dictionary<Player,int>();
        
        foreach (var player in Players)
        {
            int playerPoints = 0;
            
            foreach (var card in player.Hand)
            {
                if (card is SpecialCard)
                {
                    playerPoints += 20;
                }
                else if (card is BasicCard basicCard)
                {
                    playerPoints += basicCard.GetCardValue()[0] - '0';
                }
                else // JokerCard
                {
                    playerPoints += 50;
                }
            }
            
            pointsPerPlayer[player] = playerPoints;
        }
        
        return pointsPerPlayer;
    }
    
    public void DealCards()
    {
    	for (int i = 0; i < 7; i++)
        {
            foreach (var player in Players)
            {
                player.DrawCard(Deck);
            }
        }
    }
    
    public Dictionary<Player,int> PlayGame()
    {
        DealCards();
        DiscardPile = new Stack<Card>();
        DiscardPile.Push(new BasicCard("0", ColorEnum.ColorYellow));
        ColorEnum currentColor = ColorEnum.ColorYellow;

        while (true)
        {
            while (Deck.Count > 0)
            {
                Player currentPlayer = Players.Dequeue();
                if (currentPlayer.Play(DiscardPile, Deck, Players, currentColor))
                    return CountPoints();
                switch (DiscardPile.Peek())
                {
                    case BasicCard basicCard:
                        currentColor = basicCard.Color;
                        break;
                    case SpecialCard specialCard:
                        currentColor = specialCard.Color;
                        break;
                    case JokerCard:
                        currentColor = currentPlayer.GetBestColor();
                        break;
                }
            }
            Card topCard = DiscardPile.Pop();
            while (DiscardPile.Count > 0)
            {
                Deck.Add(DiscardPile.Pop());
            }
            DiscardPile.Push(topCard);
            ShuffleDeck();
        }
    }
}
