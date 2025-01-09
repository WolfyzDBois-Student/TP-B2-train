Hello, Train ! 

# Les Arrays

## Les base

```csharp
using System;

namespace ArrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tableaux unidimensionnels
            Console.WriteLine("Tableaux unidimensionnels:");
            SingleDimensionArray();

            // Tableaux multidimensionnels
            Console.WriteLine("\nTableaux multidimensionnels:");
            MultiDimensionArray();

            // Tableaux imbriqués
            Console.WriteLine("\nTableaux imbriqués:");
            JaggedArray();
        }

        // Méthode pour démontrer les tableaux unidimensionnels
        static void SingleDimensionArray()
        {
            // Déclaration et initialisation d'un tableau unidimensionnel
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Accès aux éléments
            Console.WriteLine("Premier élément: " + numbers[0]);
            Console.WriteLine("Dernier élément: " + numbers[numbers.Length - 1]);

            // Boucle à travers les éléments
            Console.WriteLine("Tous les éléments:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Modification d'un élément
            numbers[1] = 10;
            Console.WriteLine("Après modification: " + numbers[1]);
        }

        // Méthode pour démontrer les tableaux multidimensionnels
        static void MultiDimensionArray()
        {
            // Déclaration et initialisation d'un tableau 2D
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };

            // Accès aux éléments
            Console.WriteLine("Élément [0,1]: " + matrix[0, 1]);
            Console.WriteLine("Élément [1,2]: " + matrix[1, 2]);

            // Boucle à travers les éléments
            Console.WriteLine("Tous les éléments:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Modification d'un élément
            matrix[0, 1] = 20;
            Console.WriteLine("Après modification: " + matrix[0, 1]);
        }

        // Méthode pour démontrer les tableaux imbriqués (jagged arrays)
        static void JaggedArray()
        {
            // Déclaration et initialisation d'un tableau imbriqué
            int[][] jagged = new int[3][];
            jagged[0] = new int[] { 1, 2 };
            jagged[1] = new int[] { 3, 4, 5 };
            jagged[2] = new int[] { 6, 7, 8, 9 };

            // Accès aux éléments
            Console.WriteLine("Élément [0][1]: " + jagged[0][1]);
            Console.WriteLine("Élément [2][3]: " + jagged[2][3]);

            // Boucle à travers les éléments
            Console.WriteLine("Tous les éléments:");
            for (int i = 0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Modification d'un élément
            jagged[1][1] = 10;
            Console.WriteLine("Après modification: " + jagged[1][1]);
        }
    }
}

```


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

for (int i = 0; i < vector1.Length; ++i) 
    Console.Write(" {0}", vector1[i]); 

foreach (char elt in vector1) 
    Console.Write(" {0}", elt);
```

```csharp
int[,] matrix2 = { { 2, 3 }, { 5, 6 }, { 8, 9 } };

for (int i = 0; i < matrix2.GetLength(0); ++i)
{
    for (int j = 0; j < matrix2.GetLength(1); ++j)
        Console.Write($" {matrix2[i, j]}");
}
```

```csharp
String[][] jagged1 = new String[3][];

jagged1[0] = new String[] { "a", "b", "c" };
jagged1[1] = new String[] { "d" };
jagged1[2] = new String[] { "e", "f", "g", "h", "i" };

for (int i = 0; i < jagged1.Length; ++i)
{
	    for (int j = 0; j < jagged1[i].Length; ++j)
	        Console.Write($" {jagged1[i][j]}");
}

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

//Retrieve elements from a Queue
Console.Write("Number of elements in Queue: {0}", myQueue.Count);//4
Console.Write(myQueue.Dequeue());//Asterix
Console.Write("Number of elements in Queue: {0}", myQueue.Count);//3
Console.WriteLine(myQueue.Peek());//Justforkix    
Console.Write("Number of elements in Queue: {0}", myQueue.Count);//3
        
// Contains - look for an element
if (myQueue.Contains("Cacofonix"))
    Console.WriteLine("Does contain Cacofonix");
    
if (!myQueue.Contains("Asterix")) ... 
    	 
//Clear Queue
myQueue.Clear();
```
> [!TIPS]
> Attention à la différence entre Enqueue et Peek : Enqueue retire et Peek non il récupère juste (à confirmer)

## Stack

```cs
//Create and Add Elements in Stack
Stack<string> myStack = new Stack<string>();
myStack.Push("Asterix");

//Display Stacks' elements
foreach (var item in myStack)
    Console.Write(item + ","); 

//Retrieve elements from a Stack
Console.Write("Number of elements in Stack: {0}", myStack.Count);//4
	 
Console.Write(myStack.Pop()); // Retire l'élément
Console.WriteLine(myStack.Peek());    

// Contains - look for an element
if (myStack.Contains("Geriatrix"))
    Console.WriteLine("Does contain Geriatrix");
if (!myStack.Contains("Operatix")) ...
    
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

### Global POO 

```csharp
using System;

namespace POOExamples
{
    // Classe de base (Base Class)
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} makes a sound.");
        }
    }

    // Classe dérivée (Derived Class)
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string name, string breed) : base(name)
        {
            Breed = breed;
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} barks.");
        }

        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching!");
        }
    }

    // Autre classe dérivée
    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine($"{Name} meows.");
        }

        public void Scratch()
        {
            Console.WriteLine($"{Name} is scratching!");
        }
    }

    // Classe principale pour démonstration
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciation des objets Dog et Cat
            Dog dog = new Dog("Rex", "German Shepherd");
            Cat cat = new Cat("Whiskers");

            // Appel des méthodes
            dog.Speak();
            dog.Fetch();

            cat.Speak();
            cat.Scratch();

            // Utilisation de la classe de base
            Animal genericAnimal = new Animal("Generic Animal");
            genericAnimal.Speak();

            // Polymorphisme : appel de la méthode Speak selon le type réel de l'objet
            Animal myDog = new Dog("Buddy", "Labrador");
            Animal myCat = new Cat("Mittens");

            myDog.Speak();
            myCat.Speak();

            // Conversion implicite et explicite
            Animal someAnimal = new Dog("Charlie", "Bulldog");
            if (someAnimal is Dog someDog)
            {
                someDog.Fetch();
            }
        }
    }
}

```

### Global Collections

```csharp
using System;
using System.Collections.Generic;

namespace CollectionsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Listes
            Console.WriteLine("Listes:");
            ListExample();

            // Dictionnaires
            Console.WriteLine("\nDictionnaires:");
            DictionaryExample();

            // Files (Queues)
            Console.WriteLine("\nFiles (Queues):");
            QueueExample();

            // Piles (Stacks)
            Console.WriteLine("\nPiles (Stacks):");
            StackExample();
        }

        // Méthode pour démontrer l'utilisation des Listes
        static void ListExample()
        {
            // Déclaration et initialisation d'une liste
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // Ajout d'un élément
            numbers.Add(6);

            // Accès aux éléments
            Console.WriteLine("Premier élément: " + numbers[0]);
            Console.WriteLine("Dernier élément: " + numbers[numbers.Count - 1]);

            // Boucle à travers les éléments
            Console.WriteLine("Tous les éléments:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            // Suppression d'un élément
            numbers.Remove(3);
            Console.WriteLine("Après suppression du numéro 3:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        // Méthode pour démontrer l'utilisation des Dictionnaires
        static void DictionaryExample()
        {
            // Déclaration et initialisation d'un dictionnaire
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                { "Alice", 30 },
                { "Bob", 25 }
            };

            // Ajout d'un élément
            ages["Charlie"] = 35;

            // Accès aux éléments
            Console.WriteLine("Age de Alice: " + ages["Alice"]);

            // Boucle à travers les éléments
            Console.WriteLine("Tous les éléments:");
            foreach (var kvp in ages)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            // Suppression d'un élément
            ages.Remove("Bob");
            Console.WriteLine("Après suppression de Bob:");
            foreach (var kvp in ages)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }

        // Méthode pour démontrer l'utilisation des Files (Queues)
        static void QueueExample()
        {
            // Déclaration et initialisation d'une file
            Queue<string> queue = new Queue<string>();

            // Enqueue (ajout) d'éléments
            queue.Enqueue("Premier");
            queue.Enqueue("Deuxième");
            queue.Enqueue("Troisième");

            // Dequeue (retrait) d'un élément
            Console.WriteLine("Retrait: " + queue.Dequeue());

            // Visualisation du prochain élément
            Console.WriteLine("Prochain élément: " + queue.Peek());

            // Boucle à travers les éléments
            Console.WriteLine("Tous les éléments dans la file:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }

        // Méthode pour démontrer l'utilisation des Piles (Stacks)
        static void StackExample()
        {
            // Déclaration et initialisation d'une pile
            Stack<string> stack = new Stack<string>();

            // Push (ajout) d'éléments
            stack.Push("Premier");
            stack.Push("Deuxième");
            stack.Push("Troisième");

            // Pop (retrait) d'un élément
            Console.WriteLine("Retrait: " + stack.Pop());

            // Visualisation du prochain élément
            Console.WriteLine("Prochain élément: " + stack.Peek());

            // Boucle à travers les éléments
            Console.WriteLine("Tous les éléments dans la pile:");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
```

### Application 

Création d'un tableau de taille 5 x 2, avec chaque case un array de taille 3, et dedans une liste avec des entiers
```csharp
using System;
using System.Collections.Generic;

namespace NestedArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Déclaration du tableau principal de taille 5 x 2
            List<int>[,][] nestedArray = new List<int>[5, 2][];

            // Boucle à travers le tableau principal
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    // Initialisation du sous-tableau de taille 3
                    nestedArray[i, j] = new List<int>[3];

                    // Boucle à travers chaque élément du sous-tableau
                    for (int k = 0; k < 3; k++)
                    {
                        // Initialisation de la liste avec un nombre entier
                        nestedArray[i, j][k] = new List<int> { i * 10 + j * 5 + k };
                    }
                }
            }

            // Affichage des éléments du tableau imbriqué
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"nestedArray[{i}, {j}]: ");
                    for (int k = 0; k < 3; k++)
                    {
                        Console.Write("{ ");
                        foreach (int number in nestedArray[i, j][k])
                        {
                            Console.Write(number + " ");
                        }
                        Console.Write("} ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
```