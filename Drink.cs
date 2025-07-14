namespace RecipesManagement;

public class Drink : Recipe, Menu.IOptionItem
{
    public bool IsAlcoholic { get; set; }
    public TEMPERATURE Temperature { get; set; }

    public Drink(string name, string description, int timeInMinutes, double portions, bool IsVegeterian,
        List<string> ingredients, List<string> instructions, bool isAlcoholic, TEMPERATURE temperature) : base(name,
        description, timeInMinutes, portions, IsVegeterian, ingredients, instructions)
    {
        this.IsAlcoholic = isAlcoholic;
        this.Temperature = temperature;

    }

    public Drink()
    {
        
    }

    public override void DisplayDetails()
    {
        PrintRecipe();
        Console.WriteLine($"\nIs Alcoholic? {(IsAlcoholic ? "Yes" : "No")}");
        Console.WriteLine($"Temperature: {Temperature}");
    }
    
    public static List<Drink> GenerateDrinks()
    {
        List<Drink> drinks = new List<Drink>{};
        return drinks;
    }
    
}
    
