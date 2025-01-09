namespace Tutorial;

public class Field_Property
{
    // Il faut différencier field et property
    
    // Field
    private string Hey; 
    
    // Property 
    private string? Coucou { get; set; }
    
    // Ensuite, on créer le constructeur
    public Field_Property(string message)
    {
        // La valeur message sera donné à Hey
        Hey = message;
        // Ailleurs, on appellera le constructeur avec le message
    }
    
    // Pour récupérer la valeur d'un field on peut utiliser une méthode
    public string GetCardValue()
    {
        return Hey;
    }
}