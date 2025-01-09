using UnoAdventure.Cards;

namespace UnoAdventure;

using UnoAdventure.Cards;

public class Player
{
    public Card[] Hand { get; set; }
    public ushort NbCards => (ushort)Hand.Length;
    // public GameManager Game { get; set; }
    public string Name { get; }
    
    public Player(string name)
    {
        Name = name;
        Hand = new Card[0];
    }
    public Dictionary<ColorEnum, ushort> GetNumberOfCardsByColor()
    {
        Dictionary<ColorEnum, ushort> res = new Dictionary<ColorEnum, ushort>();
        foreach (ColorEnum color in Enum.GetValues(typeof(ColorEnum)))
        {
            res[color] = 0;
        }
        // res[ColorEnum.ColorRed] = 0;
        // res[ColorEnum.ColorBlue] = 0;
        // res[ColorEnum.ColorGreen] = 0;
        // res[ColorEnum.ColorYellow] = 0;
        
        foreach (Card card in Hand)
        {
            if (card is SpecialCard specialCard)
            {
                res[specialCard.Color]++;
            }
            else if (card is BasicCard basicCard)
            {
                res[basicCard.Color]++;
            }
        }
        return res;
    }
    public ColorEnum GetBestColor()
    {
        Dictionary<ColorEnum, ushort> numberOfCardsByColor = GetNumberOfCardsByColor();
        ColorEnum bestColor = ColorEnum.ColorGreen;
        ushort max = numberOfCardsByColor[ColorEnum.ColorGreen];
        
        foreach (KeyValuePair<ColorEnum, ushort> pair in numberOfCardsByColor)
        {
            if (pair.Value > max)
            {
                max = pair.Value;
                bestColor = pair.Key;
            }
        }
        
        return bestColor;
    }
    public List<Card>[] GetCardsByColor()
    {
        List<Card>[] res = new List<Card>[5];
        
        for (int i = 0; i < res.Length; i++)
            res[i] = new List<Card>();
        
        foreach (Card card in Hand)
        {
            if (card is SpecialCard specialCard)
            {
                res[(int)specialCard.Color].Add(card);
            }
            else if (card is BasicCard basicCard)
            {
                res[(int)basicCard.Color].Add(card);
            }
            else // JokerCard
            {
                res[4].Add(card);
            }
        }
        
        return res;
    }
    public int GetMaxIndexCard(List<Card> cards, int start)
    {
        int maxIndex = start;
        
        for (int i = start; i < cards.Count; i++)
        {
            if (String.Compare(cards[i].GetCardValue(), cards[maxIndex].GetCardValue(), StringComparison.Ordinal) > 0)
            {
                maxIndex = i;
            }
        }
        
        return maxIndex;
    }
    public void SortCardsWithSameColor(List<Card> cards)
    {
        for (int i = 0; i < cards.Count - 1; i++)
        {
            int maxIndex = GetMaxIndexCard(cards, i);
            (cards[i], cards[maxIndex]) = (cards[maxIndex], cards[i]);
            // Card tmp = cards[i];
            // cards[i] = cards[minIndex];
            // cards[minIndex] = tmp;
        }
    }
    public void SortHand()
    {
        List<Card>[] cardsByColor = GetCardsByColor();

        foreach (List<Card> cards in cardsByColor)
            SortCardsWithSameColor(cards);
        
        Card[] newHand = new Card[NbCards];
        int index = 0;
        
        foreach (List<Card> cards in cardsByColor)
        {
            foreach (Card card in cards)
            {
                newHand[index++] = card;
                // newHand[index] = card;
                // index++;
            }
        }
        
        Hand = newHand;
    }
    public void DrawCard(List<Card> deck)
    {
        Card[] newHand = new Card[NbCards + 1]; 
        
        for (int i = 0; i < NbCards; i++)
            newHand[i] = Hand[i];
        
        newHand[NbCards] = deck[0];
        deck.RemoveAt(0);
        Hand = newHand;
    }
    public void UseCard(Card card, Stack<Card> stack)
    {
        stack.Push(card);
        Card[] newHand = new Card[NbCards - 1];
        int index = 0;
        
        for (int i = 0; i < NbCards; i++)
        {
            if (Hand[i] != card)
            {
                newHand[index++] = Hand[i];
            }
        }
        
        Hand = newHand;
    }
    private bool CanPlay(Card card, Card previousCard, ColorEnum actualColor)
    {
        if (card is SpecialCard specialCard)
            return actualColor == specialCard.Color || card.GetCardValue() == previousCard.GetCardValue();

        if (card is BasicCard basicCard)
            return actualColor == basicCard.Color || card.GetCardValue() == previousCard.GetCardValue();
        
        return true;
    }
    
    public bool Play(Stack<Card> pile, List<Card> deck, Queue<Player> players, ColorEnum actualColor)
    {
        // Regarde sa main de gauche à droite, s'il peut jouer une carte, il la joue
        // s'il ne peut pas jouer, il pioche une carte
        
        for (int i = 0; i < NbCards; i++)
        {
            if (CanPlay(Hand[i], pile.Peek(), actualColor))
            {
                Card card = Hand[i];
                UseCard(card, pile);
                switch (card)
                {
                    case BasicCard:
                        players.Enqueue(this);
                        break;
                    case SpecialCard specialCard:
                        specialCard.UseCapacity(this, players, deck);
                        break;
                    case JokerCard jokerCard:
                        jokerCard.UseCapacity(this, players, deck);
                        break;
                }
                return NbCards == 0;
            }
        }
        DrawCard(deck);
        return false;
    }
}