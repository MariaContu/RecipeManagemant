namespace RecipesManagement;

public abstract class Recipe
{
    private string Name { get; set; }
    private string Description { get; set; } 
    private int TimeInMinutes { get; set; }
    private int Portions { get; set; }
    private List<Ingredient> Ingredients { get; set; }
    private List<string> Instructions { get; set; }

    public Recipe(string name, string description, int timeInMinutes, int portions, List<Ingredient> ingredients, List<string> instructions)
    {
        Name = name;
        Description = description;
        TimeInMinutes = timeInMinutes;
        Portions = portions;
        Ingredients = ingredients;
        Instructions = instructions;
    }
    
    public abstract void DisplayDetails();

    public virtual void MultiplyRecipe()
    {
        Console.WriteLine("Você quer aumentar a receita em quantas vezes?");
        int quantity = int.Parse(Console.ReadLine());

        //multiply portions, time and ingredients
        foreach (Ingredient i in Ingredients)
        {
            //
        }
    }
    
    public virtual void PrintRecipe()
    {
        Console.WriteLine($"\n--- {Name.ToUpper()} ---\n");
        Console.WriteLine($"Descrição: {Description}");
        Console.WriteLine($"Tempo de Preparo: {TimeInMinutes} minutos");
        Console.WriteLine($"Porções: {Portions}");
        Console.WriteLine("\nIngredientes:");
        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine($"- {ingredient}");
        }
        Console.WriteLine("\nModo de Preparo:");
        for (int i = 0; i < Instructions.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Instructions[i]}");
        }
    }
    
}