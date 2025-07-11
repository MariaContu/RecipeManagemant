namespace RecipesManagement;

public abstract class Recipe
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public int TimeInMinutes { get; protected set; }
    public double Portions { get; protected set; }
    public bool IsVegetarian { get; protected set; }
    public List<Ingredient> Ingredients { get; protected set; }
    public List<string> Instructions { get; protected set; }

    protected Recipe(string name, string description, int timeInMinutes, double portions, bool isVegetarian, List<Ingredient> ingredients, List<string> instructions)
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
        Ingredients = new List<Ingredient>();
        Instructions = new List<string>();
    }

    public abstract void DisplayDetails();

    public virtual void MultiplyRecipe()
    {
        Console.WriteLine("How many times do you aim to grow your recipe?");
        if (double.TryParse(Console.ReadLine(), out double quantity) && quantity > 0)
        {
            foreach (Ingredient i in Ingredients)
            {
                i.Quantity *= quantity;
            }

            Portions *= quantity;

            PrintRecipe();
        }
        else
        {
            Console.WriteLine("Invalid quantity.");
        }
    }

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