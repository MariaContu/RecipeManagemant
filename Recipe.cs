namespace RecipesManagement;

public abstract class Recipe
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int TimeInMinutes { get; set; }
    public double Portions { get; set; }
    public bool IsVegetarian { get; set; }
    public List<string> Ingredients { get; set; }
    public List<string> Instructions { get; set; }

    protected Recipe(string name, string description, int timeInMinutes, double portions, bool isVegetarian, List<string> ingredients, List<string> instructions)
    {
        Name = name;
        Description = description;
        TimeInMinutes = timeInMinutes;
        Portions = portions;
        IsVegetarian = isVegetarian;
        Ingredients = ingredients;
        Instructions = instructions;
    }

    protected Recipe()
    {
        Ingredients = new List<string>();
        Instructions = new List<string>();
    }

    public abstract void DisplayDetails();
    

    public virtual void PrintRecipe()
    {
        Console.WriteLine($"\n--- {Name.ToUpper()} ---\n");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Preparation Time: {TimeInMinutes} minutes");
        Console.WriteLine($"Portions: {Portions}");
        Console.WriteLine($"Is Vegetarian: {(IsVegetarian ? "Sim" : "Não")}");
        Console.WriteLine("\nIngredients:");
        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine($"- {ingredient}");
        }
        Console.WriteLine("\nInstructions:");
        foreach (string v in Instructions)
        {
            Console.WriteLine($"- {v}");
        }
    }
    
}