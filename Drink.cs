namespace RecipesManagement;

public class Drink : Recipe
{
    private bool isAlcoholic;

    private TEMPERATURE temperature;

    public Drink(string name, string description, int timeInMinutes, double portions, bool IsVegeterian,
        List<Ingredient> ingredients, List<string> instructions, bool isAlcoholic, TEMPERATURE temperature) : base(name,
        description, timeInMinutes, portions, IsVegeterian, ingredients, instructions)
    {
        this.isAlcoholic = isAlcoholic;
        this.temperature = temperature;

    }

    public void getIsAlcoholic()
    {
        this.isAlcoholic = false;
    }

    public void getTemperature()
    {
        this.temperature = (TEMPERATURE)temperature;
    }

    public void Alcoholic()
    {
        if (isAlcoholic)
        {
            Console.WriteLine("Is Alcoholic.");
        }
        else
        {
            Console.WriteLine("Is Not Alcoholic.");
        }
    }

    public override void DisplayDetails()
    {
        throw new NotImplementedException();
    }
}
    
