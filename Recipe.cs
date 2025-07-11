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
        Console.WriteLine("Você quer aumentar a receita em quantas vezes?");
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
            Console.WriteLine("Quantidade inválida.");
        }
    }

    public virtual void PrintRecipe()
    {
        Console.WriteLine($"\n--- {Name.ToUpper()} ---\n");
        Console.WriteLine($"Descrição: {Description}");
        Console.WriteLine($"Tempo de Preparo: {TimeInMinutes} minutos");
        Console.WriteLine($"Porções: {Portions}");
        Console.WriteLine($"Vegetariana: {(IsVegetarian ? "Sim" : "Não")}");
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