Hello, Train ! 

# Les Arrays

## Initialisation simple

```cs
public Card[] Hand { get; set; } // POO

public Player()
{
    Hand = new Card[0]; // Init un array de taille 0
}
```

### Simple dimension
```csharp
int[] vector1;
vector1 = new int[8];

int[] vector1bis = new int[5];

int[] vector2 = new int[] { 2, 4, 6, 8 };
char[] vector3 = { 'a', 'b', 'c', 'd' };
```

### Mutli dimension

```csharp
int[,] matrix2D1 = new int[2, 2];

matrix2D1[0, 0] = 1;
matrix2D1[0, 1] = 2;
matrix2D1[1, 0] = 3;
matrix2D1[1, 1] = 4;

int[,] matrix2D2 = { { 2, 3 },
                     { 5, 6 },
                     { 8, 9 } 
};

int[,,] matrix3D2 = new int[,,] { 
						{ { 1, 2, 3 }, { 4, 5, 6 } },
						{ { 7, 8, 9 }, { 10, 11, 12 } } 
						};
```

### Jagged Array

```csharp
String[][] jagged1 = new String[3][];

jagged1[0] = new String[] { "a", "b", "c" };
jagged1[1] = new String[] { "d" };
jagged1[2] = new String[] { "e", "f", "g", "h", "i" };

char[][] jagged2 =
{
new char[] { 'a', 'b', 'c' },
new char[] { 'd', 'e' },
new char[] { 'f', 'g', 'h', 'i' }
};

int[] vector = {1, 2, 3, 4, 5};
int[][] jagged3 = { vector, vector };
```

### Display

#### Simple Dimension

```csharp
char[] vector1 = { 'a', 'b', 'c', 'd' };

	 

	Console.Write("vector:");

	for (int i = 0; i < vector1.Length; ++i) 

	    Console.Write(" {0}", vector1[i]); 

	Console.WriteLine();

	//vector: a b c d

	 

	foreach (char elt in vector1) 

	    Console.Write(" {0}", elt);
```

```csharp
int[,] matrix2 = { { 2, 3 }, { 5, 6 }, { 8, 9 } };

	 

	Console.WriteLine("matrix:");

	for (int i = 0; i < matrix2.GetLength(0); ++i)

	{

	    for (int j = 0; j < matrix2.GetLength(1); ++j)

	        Console.Write($" {matrix2[i, j]}");

	    Console.WriteLine();

	}

	 

	/*

	 * matrix:

	 *   2 3

	 *   5 6

	 *   8 9 

	 */
```

```csharp
String[][] jagged1 = new String[3][];

	jagged1[0] = new String[] { "a", "b", "c" };

	jagged1[1] = new String[] { "d" };

	jagged1[2] = new String[] { "e", "f", "g", "h", "i" };

	 

	Console.WriteLine("jagged:");

	for (int i = 0; i < jagged1.Length; ++i)

	{

	    for (int j = 0; j < jagged1[i].Length; ++j)

	        Console.Write($" {jagged1[i][j]}");

	    Console.WriteLine();

	}

	 

	/*

	 * jagged:

	 *  a b c    

	 *  d        

	 *  e f g h i

	 */
```

Avoir la taille : `Hand.Length`

> [!CAUTION]
> L'index est très important

# Dictionnaire

```cs

// Dictionnaire de string, avec des clés en int
var dict = new Dictionary<int, string>();

// Ajout d'éléments (2 moyens)
dict.Add(2, "Justforkix");
dict[8] = "Operatix";

// Accéder à un élément (attention aux index en-dehors)
var gaulish6 = dict[6];
	 
// Supprimer un élément
dict.Remove(6);

// Afficher les éléments
foreach (var kvp in dict) 
    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
```

> [!WARNING]
> On peut avoir plusieurs fois la même valeur, mais pas la même clé (ici on peut avoir 2 "Astérix" mais pas 2 fois 6)


# Listes

```cs
// Création
var gaulish = new List<string>();

// Ajout d'élément
gaulish.Add("Asterix");

// Accéder à un élément
Console.WriteLine(gaulish[]); //Dogmatix

// Insérer des éléments (entre 2 élements)
gaulish.Insert(3, "Vitalstatistix");

// Supprimer
gaulish.Remove("Vitalstatistix"); // Vakeyr
gaulish.RemoveAt(3); // Index

// Afficher avec foreach
Console.WriteLine(gaulish); //System.Collections.Generic.List`1[System.String]
gaulish.ForEach(item => Console.Write($"{item}, ")); //Asterix, Obelix, Dogmatix, Getafix,

// Vérifier si un élément est dedans
if (gaulish.Contains("Obelix")) ...

// Autres recherches 
if (gaulish.Exists(x => x.Contains("Ast")))
	Console.WriteLine("Exists Ast");

var res = gaulish.Find(x => x.Contains("Dogma"));
Console.WriteLine($"Find: {res}"); //Find: Dogmatix
var index = gaulish.FindIndex(x => x.Contains("lix"));
Console.WriteLine($"First lix find at {index}"); //First lix find at 1
var even = gaulish.FindAll(x => x.Contains("ix"));
even.ForEach(item => Console.Write($"{item}, ")); //Asterix, Obelix, Dogmatix, Getafix,
	 
// Avoir quelques éléments
var sub = gaulish.GetRange(1, 2);
sub.ForEach(item => Console.Write($"{item}, ")); //Obelix, Dogmatix,
```


# Queue

```cs
//Create and Add Elements in Queue
Queue<string> myQueue = new Queue<string>();
myQueue.Enqueue("Asterix");

//Display Queues' elements

	foreach (var item in myQueue)

	    Console.Write(item + ",");

	Console.WriteLine();

	//Asterix,Justforkix,Cacofonix,Obelix,

	 

	//Retrieve elements from a Queue

	Console.Write("Number of elements in Queue: {0}", myQueue.Count);//4

	Console.WriteLine();

	 

	Console.Write(myQueue.Dequeue());//Asterix

	Console.WriteLine();
    Console.Write("Number of elements in Queue: {0}", myQueue.Count);//3
    
    	Console.WriteLine();
    
    	 
    
    	Console.WriteLine(myQueue.Peek());//Justforkix
    
    	Console.WriteLine();
    
    	Console.Write("Number of elements in Queue: {0}", myQueue.Count);//3
    
    	Console.WriteLine();
    
    	 
    
    	// Contains - look for an element
    
    	if (myQueue.Contains("Cacofonix"))
    
    	    Console.WriteLine("Does contain Cacofonix");
    
    	 
    
    	if (!myQueue.Contains("Asterix"))
    
    	    Console.WriteLine("Does not contain Asterix");
    
    	 
    
    	//Clear Queue
    
    	myQueue.Clear();
    
    	Console.Write("Number of elements in Queue: {0}", myQueue.Count);//0
    	
```


## Stack

```cs
//Create and Add Elements in Stack

	Stack<string> myStack = new Stack<string>();

	myStack.Push("Asterix");

	myStack.Push("Obelix");

	myStack.Push("Geriatrix");

	myStack.Push("Operatix");

	 

	//Display Stacks' elements

	foreach (var item in myStack)

	    Console.Write(item + ","); 

	Console.WriteLine();

	//Operatix,Geriatrix,Obelix,Asterix,

	 

	//Retrieve elements from a Stack

	Console.Write("Number of elements in Stack: {0}", myStack.Count);//4

	Console.WriteLine();

	 

	Console.Write(myStack.Pop());//Operatix

	Console.WriteLine();
	Console.Write("Number of elements in Stack: {0}", myStack.Count);//3
    
    	Console.WriteLine();
    
    	 
    
    	 
    
    	Console.WriteLine(myStack.Peek());//Geriatrix
    
    	Console.WriteLine();
    
    	Console.Write("Number of elements in Stack: {0}", myStack.Count);//3
    
    	Console.WriteLine();
    
    	 
    
    	// Contains - look for an element
    
    	if (myStack.Contains("Geriatrix"))
    
    	    Console.WriteLine("Does contain Geriatrix");
    
    	 
    
    	if (!myStack.Contains("Operatix"))
    
    	    Console.WriteLine("Does not contain Operatix");
    
    	 
    
    	//Clear Stack
    
    	myStack.Clear();
    
    	Console.Write("Number of elements in Stack: {0}", myStack.Count);//0
```


# POO

## Enum

```cs
public enum ColorEnum
{
    ColorGreen = 0,
    ColorRed = 1,
    ColorBlue = 2,
    ColorYellow = 3
}
```

On peut attribuer des valeurs, ou récupérer la valeur
```cs
    ColorEnum  myvar = ColorEnum.ColorGreen;
```

## Field & Property

```cs
public class Card
{
    // Field
    private string Value;

    // Constructeur
    public Card(string cardValue)
    {
        Value = cardValue;
    }

    // Méthode pour récupérer la valeur de Value
    public string GetCardValue()
    {
        return Value;
    }
}
```

> [!CAUTION]
> Attention à ne pas confondre Atteribut (= field) et Property (avec getter et setter)

> [!WARNING]
> Un constructeur est indispensable

## Créer la parentalité

public class BasicCard : Card
{
    public ColorEnum Color;

    public BasicCard(string cardValue, ColorEnum cardColor) : base(cardValue)
    {
        if (cardValue.Length > 1 || cardValue[0] < '0' || cardValue[0] > '9')
        {
            throw new UnoException();
        }

        Color = cardColor;
    }
}

Ici, le `:Card` permet de rendre BasicCard enfant de Card, et Card est parent.

> [!CAUTION]
> On ne définie pas la valeur avec un `Value = ` mais en utilisant le mot ` : base(cardValue)` dans la définition de la méthode

## Custom Exception

```cs
public class UnoException : Exception { }

public GaulsException() :base ("A problem happened in the village"){ }
public GaulsException(string message) :base ($"A problem happened in the village: {message}") { }

throw new UnoException();
```

## Test unitaire : Constructeur

```cs
Card card = new Card("7");
Assert.Equal("7", card.GetCardValue());
```

## Getter

```cs
public string Name { get; }

    public Card[] Hand { get; set; }

    public ushort NbCards
    {
        get
        {
            return NbCards;
        }
    }
```
