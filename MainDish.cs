namespace RecipesManagement;

using System;

class MainDish : Recipe
{
    public PROTEIN ProteinType { get; set; }
    public CUISINE CuisineType { get; set; }

    public MainDish(string name, string description, int timeInMinutes, double portions, bool isVegetarian, List<Ingredient> ingredients, List<string> instructions, PROTEIN proteinType, CUISINE cuisineType)
        : base(name, description, timeInMinutes, portions, isVegetarian, ingredients, instructions)
    {
        ProteinType = proteinType;
        CuisineType = cuisineType;
    }

    public override void DisplayDetails()
    {
        PrintRecipeDetails();
        Console.WriteLine($"Protein: {ProteinType}");
        Console.WriteLine($"Cuisine: {CuisineType}");
    }


    //Randomly suggests a side dish from a list of recipes.
    //Returns the name of the suggested side dish.
    public string SuggestedSideDish(List<Recipe> recipes)
    {
        Random random = new Random();
        if (recipes.Count == 0)
        {
            return "No side dishes available.";
        }
        int randomIndex = random.Next(recipes.Count);
        Recipe randomRecipe = recipes[randomIndex];

        return randomRecipe.Name;
    }
}