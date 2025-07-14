namespace RecipesManagement;

using System;

class MainDish : Recipe, Menu.IOptionItem 
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
        Console.Clear();
        PrintRecipe();
        Console.WriteLine($"Cuisine: {CuisineType}");
        Console.WriteLine($"Protein: {ProteinType}");

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
            new MainDish("Spaghetti Bolognese", "Classic Italian pasta dish with meat sauce.", 45, 4, false,
                new List<string> { "Ground Beef", "Tomato Passata", "Spaghetti" },
                new List<string> { "Cook meat", "Add sauce", "Serve with pasta" }, PROTEIN.MEAT, CUISINE.ITALIAN),

            new MainDish("Chicken Tikka Masala", "Creamy and spicy Indian chicken curry.", 60, 4, false,
                new List<string> { "Chicken Breast", "Yogurt", "Tomato Puree" },
                new List<string> { "Marinate chicken", "Cook curry", "Serve with rice" }, PROTEIN.CHICKEN, CUISINE.INDIAN),

            new MainDish("Tacos al Pastor", "Mexican street tacos with marinated pork.", 75, 4, false,
                new List<string> { "Pork Shoulder", "Pineapple", "Onion", "Tortillas" },
                new List<string> { "Marinate pork", "Grill", "Assemble tacos" }, PROTEIN.MEAT, CUISINE.MEXICAN),

            new MainDish("Sushi Rolls", "Assorted Japanese sushi rolls.", 60, 2, false,
                new List<string> { "Sushi Rice", "Fish Fillet", "Nori" },
                new List<string> { "Cook rice", "Prepare fish", "Roll sushi" }, PROTEIN.FISH, CUISINE.JAPANESE),

            new MainDish("Hamburger", "Classic American beef burger.", 30, 1, false,
                new List<string> { "Ground Beef", "Burger Bun", "Lettuce" },
                new List<string> { "Form patty", "Grill", "Assemble burger" }, PROTEIN.MEAT, CUISINE.AMERICAN),

            new MainDish("Pad Thai", "Stir-fried rice noodle dish.", 35, 2, false,
                new List<string> { "Rice Noodles", "Shrimp", "Egg", "Peanuts" },
                new List<string> { "Soak noodles", "Stir-fry ingredients", "Serve with peanuts" }, PROTEIN.FISH, CUISINE.THAI),

            new MainDish("Feijoada", "Traditional Brazilian black bean and pork stew.", 180, 8, false,
                new List<string> { "Black Beans", "Pork Ribs", "Smoked Sausage" },
                new List<string> { "Soak beans", "Cook meats", "Combine" }, PROTEIN.MEAT, CUISINE.BRAZILIAN),

            new MainDish("Vegetable Lasagna", "Layered pasta dish with vegetables and cheese.", 90, 6, true,
                new List<string> { "Lasagna Noodles", "Ricotta Cheese", "Spinach", "Tomato Sauce" },
                new List<string> { "Prepare vegetables", "Layer ingredients", "Bake" }, PROTEIN.CHICKPEA, CUISINE.ITALIAN),

            new MainDish("Fish and Chips", "Classic British battered fish with fries.", 40, 2, false,
                new List<string> { "Cod Fillet", "Potatoes", "Flour" },
                new List<string> { "Batter fish", "Fry fish and chips" }, PROTEIN.FISH, CUISINE.AMERICAN),

            new MainDish("Beef Stroganoff", "Russian dish of sautéed beef in a sour cream sauce.", 50, 4, false,
                new List<string> { "Beef Sirloin", "Onion", "Mushrooms", "Sour Cream" },
                new List<string> { "Cook beef", "Sauté vegetables", "Add sauce" }, PROTEIN.MEAT, CUISINE.AMERICAN),

            new MainDish("Chicken Alfredo", "Creamy pasta dish with chicken.", 30, 2, false,
                new List<string> { "Fettuccine", "Chicken Breast", "Heavy Cream", "Parmesan Cheese" },
                new List<string> { "Cook pasta and chicken", "Make sauce", "Combine" }, PROTEIN.CHICKEN, CUISINE.ITALIAN),

            new MainDish("Lentil Soup", "Hearty and healthy vegetarian lentil soup.", 60, 6, true,
                new List<string> { "Lentils", "Carrot", "Celery Stalk", "Onion" },
                new List<string> { "Sauté vegetables", "Add lentils and broth", "Simmer" }, PROTEIN.CHICKPEA, CUISINE.OTHER),

            new MainDish("Chicken Quesadillas", "Cheesy chicken-filled tortillas.", 25, 2, false,
                new List<string> { "Cooked Chicken", "Tortillas", "Cheddar Cheese" },
                new List<string> { "Fill tortillas", "Cook on griddle" }, PROTEIN.CHICKEN, CUISINE.MEXICAN),

            new MainDish("Stir-fry Tofu with Vegetables", "Quick and healthy stir-fry.", 30, 2, true,
                new List<string> { "Tofu", "Broccoli", "Bell Pepper", "Soy Sauce" },
                new List<string> { "Press tofu", "Stir-fry vegetables and tofu", "Add sauce" }, PROTEIN.SOY, CUISINE.CHINESE),

            new MainDish("Shepherd's Pie", "Minced meat filling topped with mashed potato.", 75, 6, false,
                new List<string> { "Ground Lamb", "Potatoes", "Peas", "Carrots" },
                new List<string> { "Cook meat filling", "Prepare mash", "Assemble and bake" }, PROTEIN.MEAT, CUISINE.AMERICAN),

            new MainDish("Pizza Margherita", "Simple and classic Italian pizza.", 20, 2, true,
                new List<string> { "Pizza Dough", "Tomato Sauce", "Mozzarella Cheese", "Basil" },
                new List<string> { "Stretch dough", "Add toppings", "Bake" }, PROTEIN.CHICKPEA, CUISINE.ITALIAN),

            new MainDish("Roasted Chicken", "Whole roasted chicken with herbs.", 120, 4, false,
                new List<string> { "Whole Chicken", "Lemon", "Rosemary" },
                new List<string> { "Season chicken", "Roast in oven" }, PROTEIN.CHICKEN, CUISINE.AMERICAN),

            new MainDish("Chicken Noodle Soup", "Hearty and comforting chicken soup.", 60, 6, false,
                new List<string> { "Chicken Breast", "Egg Noodles", "Carrot", "Celery Stalk" },
                new List<string> { "Cook chicken and vegetables", "Add noodles", "Simmer" }, PROTEIN.CHICKEN, CUISINE.AMERICAN),

            new MainDish("Shrimp Scampi", "Garlic butter shrimp with pasta.", 30, 2, false,
                new List<string> { "Shrimp", "Linguine", "Butter", "Garlic Cloves" },
                new List<string> { "Cook pasta", "Sauté shrimp with garlic butter", "Combine" }, PROTEIN.FISH, CUISINE.ITALIAN),

            new MainDish("Falafel Wrap", "Vegetarian chickpea fritters in a wrap.", 25, 2, true,
                new List<string> { "Falafel Mix", "Pita Bread", "Tahini Sauce", "Lettuce" },
                new List<string> { "Prepare falafel", "Fry", "Assemble wrap" }, PROTEIN.CHICKPEA, CUISINE.OTHER),

            new MainDish("Salmon with Asparagus", "Healthy baked salmon and asparagus.", 25, 2, false,
                new List<string> { "Salmon Fillet", "Asparagus", "Lemon" },
                new List<string> { "Season salmon and asparagus", "Bake" }, PROTEIN.FISH, CUISINE.OTHER)
        };
        return mainDishes;
    }
}