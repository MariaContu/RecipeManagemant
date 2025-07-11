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

    public bool getIsAlcoholic()
    {
        return isAlcoholic;
    }

    public TEMPERATURE getTemperature()
    {
        return this.temperature;
    }

    public void Alcoholic()
    {
        if (isAlcoholic == true)
        {
            Console.WriteLine("Is Alcoholic.");
        }
        else
        {
            Console.WriteLine("Is Not Alcoholic.");
        }
    }
    
    public void Temperature()
    {
        switch (temperature)
        {
            case TEMPERATURE.Cold:
                Console.WriteLine("Cold Temperature");
                break;
            case TEMPERATURE.Hot:
                Console.WriteLine("Hot Temperature");
                break;
            case TEMPERATURE.Ambient:
                Console.WriteLine("Ambient Temperature");
                break;
        }
    }


    public override void DisplayDetails()
    {
        throw new NotImplementedException();
    }
}
    
