namespace RecipesManagement;

public class Drink : Recipe
{
    private bool IsAlcoholic { get; set; }
    private TEMPERATURE Temperature { get; set; }

    public Drink(string name, string description, int timeInMinutes, double portions, bool IsVegeterian,
        List<Ingredient> ingredients, List<string> instructions, bool isAlcoholic, TEMPERATURE temperature) : base(name,
        description, timeInMinutes, portions, IsVegeterian, ingredients, instructions)
    {
        this.IsAlcoholic = isAlcoholic;
        this.Temperature = temperature;

    }

    public override void DisplayDetails()
    {
        PrintRecipe();
        Console.WriteLine($"Is Alcoholic? {(IsAlcoholic ? "Yes" : "No")}");
        Console.WriteLine($"Temperature: {Temperature}");
    }
}
    
