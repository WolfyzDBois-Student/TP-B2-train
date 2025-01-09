using System.Drawing;
using UnoAdventure.Cards;

namespace UnoAdventure;

public class Player
{
    public string Name { get; }

    public Card[] Hand { get; set; }
    
    public ushort NbCards
    {
        get
        {
            return (ushort)Hand.Length;
        }
        // public ushort NbCards => (ushort)Hand.Length;
    }

    public Player(string name)
    {
        Name = name;
        Hand = new Card[0];
    }

    public Dictionary<ColorEnum, ushort> GetNumberOfCardsByColor()
    {
        var dico = new Dictionary<ColorEnum, ushort>();
        dico.Add(ColorEnum.ColorRed, 0);
        dico.Add(ColorEnum.ColorBlue, 0);
        dico.Add(ColorEnum.ColorGreen, 0);
        dico.Add(ColorEnum.ColorYellow, 0);
        foreach (Card c in Hand)
        {
            if (c is SpecialCard sc) dico[sc.Color]++;
            else if (c is BasicCard bc) dico[bc.Color]++;
        }
        return dico;
    }

}