namespace RecipesManagement;

using System;

class MainDish : Recipe
{
    public CUISINE CuisineType { get; set; }
    public PROTEIN ProteinType { get; set; }

    public MainDish(string name, string description, int timeInMinutes, double portions, bool isVegetarian, List<string> ingredients, List<string> instructions, PROTEIN proteinType, CUISINE cuisineType)
        : base(name, description, timeInMinutes, portions, isVegetarian, ingredients, instructions)
    {
        ProteinType = proteinType;
        CuisineType = cuisineType;
    }

    public MainDish()
    {
        
    }

    public override void DisplayDetails()
    {
        PrintRecipe();
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
    
    public static List<MainDish> GenerateMainDishes()
    {
        List<MainDish> mainDishes = new List<MainDish>{};
        return mainDishes;
    }
}