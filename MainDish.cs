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
        PrintRecipe();
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
    
    public static List<MainDish> GenerateMainDishes()
    {
        List<MainDish> mainDishes = new List<MainDish>
        {
            new MainDish("Spaghetti Bolognese", "Classic Italian pasta dish with meat sauce.", 45, 4, false, new List<Ingredient> { new Ingredient(300, "Ground Beef", "g"), new Ingredient(400, "Tomato Passata", "g"), new Ingredient(300, "Spaghetti", "g") }, new List<string> { "Cook meat", "Add sauce", "Serve with pasta" }, PROTEIN.MEAT, CUISINE.ITALIAN),
            new MainDish("Chicken Tikka Masala", "Creamy and spicy Indian chicken curry.", 60, 4, false, new List<Ingredient> { new Ingredient(500, "Chicken Breast", "g"), new Ingredient(200, "Yogurt", "g"), new Ingredient(100, "Tomato Puree", "g") }, new List<string> { "Marinate chicken", "Cook curry", "Serve with rice" }, PROTEIN.CHICKEN, CUISINE.INDIAN),
            new MainDish("Tacos al Pastor", "Mexican street tacos with marinated pork.", 75, 4, false, new List<Ingredient> { new Ingredient(500, "Pork Shoulder", "g"), new Ingredient(1, "Pineapple", "unit"), new Ingredient(1, "Onion", "unit"), new Ingredient(12, "Tortillas", "units") }, new List<string> { "Marinate pork", "Grill", "Assemble tacos" }, PROTEIN.MEAT, CUISINE.MEXICAN),
            new MainDish("Sushi Rolls", "Assorted Japanese sushi rolls.", 60, 2, false, new List<Ingredient> { new Ingredient(300, "Sushi Rice", "g"), new Ingredient(200, "Fish Fillet", "g"), new Ingredient(1, "Nori", "sheet") }, new List<string> { "Cook rice", "Prepare fish", "Roll sushi" }, PROTEIN.FISH, CUISINE.JAPANESE),
            new MainDish("Hamburger", "Classic American beef burger.", 30, 1, false, new List<Ingredient> { new Ingredient(200, "Ground Beef", "g"), new Ingredient(1, "Burger Bun", "unit"), new Ingredient(1, "Lettuce", "leaf") }, new List<string> { "Form patty", "Grill", "Assemble burger" }, PROTEIN.MEAT, CUISINE.AMERICAN),
            new MainDish("Pad Thai", "Stir-fried rice noodle dish.", 35, 2, false, new List<Ingredient> { new Ingredient(200, "Rice Noodles", "g"), new Ingredient(150, "Shrimp", "g"), new Ingredient(1, "Egg", "unit"), new Ingredient(50, "Peanuts", "g") }, new List<string> { "Soak noodles", "Stir-fry ingredients", "Serve with peanuts" }, PROTEIN.FISH, CUISINE.THAI),
            new MainDish("Feijoada", "Traditional Brazilian black bean and pork stew.", 180, 8, false, new List<Ingredient> { new Ingredient(500, "Black Beans", "g"), new Ingredient(500, "Pork Ribs", "g"), new Ingredient(200, "Smoked Sausage", "g") }, new List<string> { "Soak beans", "Cook meats", "Combine" }, PROTEIN.MEAT, CUISINE.BRAZILIAN),
            new MainDish("Vegetable Lasagna", "Layered pasta dish with vegetables and cheese.", 90, 6, true, new List<Ingredient> { new Ingredient(12, "Lasagna Noodles", "units"), new Ingredient(500, "Ricotta Cheese", "g"), new Ingredient(300, "Spinach", "g"), new Ingredient(400, "Tomato Sauce", "g") }, new List<string> { "Prepare vegetables", "Layer ingredients", "Bake" }, PROTEIN.CHICKPEA, CUISINE.ITALIAN),
            new MainDish("Fish and Chips", "Classic British battered fish with fries.", 40, 2, false, new List<Ingredient> { new Ingredient(300, "Cod Fillet", "g"), new Ingredient(2, "Potatoes", "units"), new Ingredient(100, "Flour", "g") }, new List<string> { "Batter fish", "Fry fish and chips" }, PROTEIN.FISH, CUISINE.AMERICAN),
            new MainDish("Beef Stroganoff", "Russian dish of sautéed beef in a sour cream sauce.", 50, 4, false, new List<Ingredient> { new Ingredient(500, "Beef Sirloin", "g"), new Ingredient(1, "Onion", "unit"), new Ingredient(200, "Mushrooms", "g"), new Ingredient(150, "Sour Cream", "g") }, new List<string> { "Cook beef", "Sauté vegetables", "Add sauce" }, PROTEIN.MEAT, CUISINE.AMERICAN),
            new MainDish("Chicken Alfredo", "Creamy pasta dish with chicken.", 30, 2, false, new List<Ingredient> { new Ingredient(200, "Fettuccine", "g"), new Ingredient(300, "Chicken Breast", "g"), new Ingredient(200, "Heavy Cream", "ml"), new Ingredient(100, "Parmesan Cheese", "g") }, new List<string> { "Cook pasta and chicken", "Make sauce", "Combine" }, PROTEIN.CHICKEN, CUISINE.ITALIAN),
            new MainDish("Lentil Soup", "Hearty and healthy vegetarian lentil soup.", 60, 6, true, new List<Ingredient> { new Ingredient(200, "Lentils", "g"), new Ingredient(1, "Carrot", "unit"), new Ingredient(1, "Celery Stalk", "unit"), new Ingredient(1, "Onion", "unit") }, new List<string> { "Sauté vegetables", "Add lentils and broth", "Simmer" }, PROTEIN.CHICKPEA, CUISINE.OTHER),
            new MainDish("Chicken Quesadillas", "Cheesy chicken-filled tortillas.", 25, 2, false, new List<Ingredient> { new Ingredient(200, "Cooked Chicken", "g"), new Ingredient(4, "Tortillas", "units"), new Ingredient(150, "Cheddar Cheese", "g") }, new List<string> { "Fill tortillas", "Cook on griddle" }, PROTEIN.CHICKEN, CUISINE.MEXICAN),
            new MainDish("Stir-fry Tofu with Vegetables", "Quick and healthy stir-fry.", 30, 2, true, new List<Ingredient> { new Ingredient(300, "Tofu", "g"), new Ingredient(150, "Broccoli", "g"), new Ingredient(1, "Bell Pepper", "unit"), new Ingredient(50, "Soy Sauce", "ml") }, new List<string> { "Press tofu", "Stir-fry vegetables and tofu", "Add sauce" }, PROTEIN.SOY, CUISINE.CHINESE),
            new MainDish("Shepherd's Pie", "Comforting dish with a minced meat filling topped with mashed potato.", 75, 6, false, new List<Ingredient> { new Ingredient(500, "Ground Lamb", "g"), new Ingredient(500, "Potatoes", "g"), new Ingredient(100, "Peas", "g"), new Ingredient(100, "Carrots", "g") }, new List<string> { "Cook meat filling", "Prepare mash", "Assemble and bake" }, PROTEIN.MEAT, CUISINE.AMERICAN),
            new MainDish("Pizza Margherita", "Simple and classic Italian pizza.", 20, 2, true, new List<Ingredient> { new Ingredient(1, "Pizza Dough", "ball"), new Ingredient(100, "Tomato Sauce", "g"), new Ingredient(150, "Mozzarella Cheese", "g"), new Ingredient(10, "Basil", "leaves") }, new List<string> { "Stretch dough", "Add toppings", "Bake" }, PROTEIN.CHICKPEA, CUISINE.ITALIAN), // Proteins for Pizza can be tricky, going with Legumes as a placeholder for cheese/bread
            new MainDish("Roasted Chicken", "Whole roasted chicken with herbs.", 120, 4, false, new List<Ingredient> { new Ingredient(1, "Whole Chicken", "unit"), new Ingredient(1, "Lemon", "unit"), new Ingredient(20, "Rosemary", "sprigs") }, new List<string> { "Season chicken", "Roast in oven" }, PROTEIN.CHICKEN, CUISINE.AMERICAN),
            new MainDish("Chicken Noodle Soup", "Hearty and comforting chicken soup.", 60, 6, false, new List<Ingredient> { new Ingredient(300, "Chicken Breast", "g"), new Ingredient(100, "Egg Noodles", "g"), new Ingredient(1, "Carrot", "unit"), new Ingredient(1, "Celery Stalk", "unit") }, new List<string> { "Cook chicken and vegetables", "Add noodles", "Simmer" }, PROTEIN.CHICKEN, CUISINE.AMERICAN),
            new MainDish("Shrimp Scampi", "Garlic butter shrimp with pasta.", 30, 2, false, new List<Ingredient> { new Ingredient(300, "Shrimp", "g"), new Ingredient(200, "Linguine", "g"), new Ingredient(50, "Butter", "g"), new Ingredient(3, "Garlic Cloves", "units") }, new List<string> { "Cook pasta", "Sauté shrimp with garlic butter", "Combine" }, PROTEIN.FISH, CUISINE.ITALIAN),
            new MainDish("Falafel Wrap", "Vegetarian chickpea fritters in a wrap.", 25, 2, true, new List<Ingredient> { new Ingredient(200, "Falafel Mix", "g"), new Ingredient(2, "Pita Bread", "units"), new Ingredient(50, "Tahini Sauce", "ml"), new Ingredient(50, "Lettuce", "g") }, new List<string> { "Prepare falafel", "Fry", "Assemble wrap" }, PROTEIN.CHICKPEA, CUISINE.OTHER),
            new MainDish("Salmon with Asparagus", "Healthy baked salmon and asparagus.", 25, 2, false, new List<Ingredient> { new Ingredient(300, "Salmon Fillet", "g"), new Ingredient(200, "Asparagus", "g"), new Ingredient(1, "Lemon", "unit") }, new List<string> { "Season salmon and asparagus", "Bake" }, PROTEIN.FISH, CUISINE.OTHER)
        };
        return mainDishes;
    }
}