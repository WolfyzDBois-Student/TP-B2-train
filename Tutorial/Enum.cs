namespace Tutorial;

public enum EnumEx
{
    // Pour énumérer, il faut mettre le nom suivi d'une virgule
    RedCart, 
    Hello,
    
    // On peut aussi donner des valeurs
    Valeur3 = 3
}

// Acéder à l'énumération 
public class Test
{
    EnumEx myvar = EnumEx.Hello;
    // Sortie Console.Writeline >> Hello
    
}