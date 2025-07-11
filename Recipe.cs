namespace RecipesManagement;

public class Recipe
{
    private string Name { get; set; }
    private string Description { get; set; } 
    private int TimeInMinutes { get; set; }
    private int Portions { get; set; }
    private List<string> Ingredients { get; set; }
    private List<string> Instructions { get; set; }

    public Recipe(string name, string description, int timeInMinutes, int portions, List<string> ingredients, List<string> instructions)
    {
        Name = name;
        Description = description;
        TimeInMinutes = timeInMinutes;
        Portions = portions;
        Ingredients = ingredients;
        Instructions = instructions;
    }
    
}