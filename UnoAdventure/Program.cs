// See https://aka.ms/new-console-template for more information

using UnoAdventure;
using UnoAdventure.Cards;

Console.WriteLine("Hello, World!");

BasicCard card = new BasicCard("7", ColorEnum.ColorRed);
Console.WriteLine(card.GetCardValue()); // Affiche "7"
Console.WriteLine(card.Color); // Affiche "ColorRed"


Player player = new Player("Alice");
player.Hand = new Card[] { new BasicCard("7", ColorEnum.ColorRed), new SpecialCard("Reverse", ColorEnum.ColorBlue) };
Dictionary<ColorEnum, ushort> cardsByColor = player.GetNumberOfCardsByColor();
Console.WriteLine(cardsByColor[ColorEnum.ColorRed]); // Affiche 1
Console.WriteLine(cardsByColor[ColorEnum.ColorBlue]); // Affiche 1
Console.WriteLine(cardsByColor[ColorEnum.ColorGreen]); // Affiche 0
Console.WriteLine(cardsByColor[ColorEnum.ColorYellow]); // Affiche 0