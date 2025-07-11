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
    
    public static List<Drink> GenerateDrinks()
    {
        List<Drink> drinks = new List<Drink>
        {
            new Drink("Water", "Plain drinking water.", 0, 1, true, new List<Ingredient> { new Ingredient(1, "Water", "liter") }, new List<string> { "Serve" }, false, TEMPERATURE.Cold),
            new Drink("Coffee", "Hot black coffee.", 5, 1, true, new List<Ingredient> { new Ingredient(10, "Coffee Beans", "g"), new Ingredient(200, "Water", "ml") }, new List<string> { "Brew coffee" }, false, TEMPERATURE.Hot),
            new Drink("Iced Tea", "Refreshing iced tea with lemon.", 10, 1, true, new List<Ingredient> { new Ingredient(1, "Tea Bag", "unit"), new Ingredient(200, "Water", "ml"), new Ingredient(50, "Ice", "cubes") }, new List<string> { "Brew tea", "Chill", "Add ice" }, false, TEMPERATURE.Cold),
            new Drink("Orange Juice", "Freshly squeezed orange juice.", 5, 1, true, new List<Ingredient> { new Ingredient(2, "Oranges", "units") }, new List<string> { "Squeeze oranges" }, false, TEMPERATURE.Cold),
            new Drink("Milkshake", "Creamy vanilla milkshake.", 5, 1, true, new List<Ingredient> { new Ingredient(200, "Milk", "ml"), new Ingredient(100, "Vanilla Ice Cream", "g") }, new List<string> { "Blend ingredients" }, false, TEMPERATURE.Cold),
            new Drink("Mojito", "Classic Cuban cocktail with rum and mint.", 10, 1, false, new List<Ingredient> { new Ingredient(60, "Rum", "ml"), new Ingredient(10, "Mint Leaves", "units"), new Ingredient(1, "Lime", "unit"), new Ingredient(100, "Soda Water", "ml") }, new List<string> { "Muddle mint and lime", "Add rum and ice", "Top with soda" }, true, TEMPERATURE.Cold),
            new Drink("Lemonade", "Sweet and sour homemade lemonade.", 15, 4, true, new List<Ingredient> { new Ingredient(4, "Lemons", "units"), new Ingredient(200, "Sugar", "g"), new Ingredient(1, "Water", "liter") }, new List<string> { "Squeeze lemons", "Dissolve sugar", "Mix with water" }, false, TEMPERATURE.Cold),
            new Drink("Hot Chocolate", "Rich and creamy hot chocolate.", 10, 1, true, new List<Ingredient> { new Ingredient(200, "Milk", "ml"), new Ingredient(30, "Cocoa Powder", "g"), new Ingredient(20, "Sugar", "g") }, new List<string> { "Heat milk", "Whisk in cocoa and sugar" }, false, TEMPERATURE.Hot),
            new Drink("Smoothie", "Healthy berry smoothie.", 5, 1, true, new List<Ingredient> { new Ingredient(100, "Mixed Berries", "g"), new Ingredient(100, "Yogurt", "g"), new Ingredient(50, "Milk", "ml") }, new List<string> { "Blend all ingredients" }, false, TEMPERATURE.Cold),
            new Drink("Espresso", "Strong, concentrated coffee shot.", 2, 1, true, new List<Ingredient> { new Ingredient(7, "Coffee Grounds", "g"), new Ingredient(30, "Water", "ml") }, new List<string> { "Brew under pressure" }, false, TEMPERATURE.Hot),
            new Drink("Margarita", "Classic tequila-based cocktail.", 5, 1, false, new List<Ingredient> { new Ingredient(60, "Tequila", "ml"), new Ingredient(30, "Lime Juice", "ml"), new Ingredient(20, "Triple Sec", "ml") }, new List<string> { "Shake with ice", "Serve in salt-rimmed glass" }, true, TEMPERATURE.Cold),
            new Drink("Green Tea", "Healthy brewed green tea.", 5, 1, true, new List<Ingredient> { new Ingredient(1, "Green Tea Bag", "unit"), new Ingredient(200, "Hot Water", "ml") }, new List<string> { "Steep tea bag" }, false, TEMPERATURE.Hot),
            new Drink("Coke", "Carbonated soft drink.", 0, 1, true, new List<Ingredient> { new Ingredient(330, "Cola", "ml") }, new List<string> { "Serve chilled" }, false, TEMPERATURE.Cold),
            new Drink("Latte", "Coffee with steamed milk and a layer of foam.", 7, 1, true, new List<Ingredient> { new Ingredient(30, "Espresso", "ml"), new Ingredient(200, "Milk", "ml") }, new List<string> { "Brew espresso", "Steam milk", "Combine" }, false, TEMPERATURE.Hot),
            new Drink("Gin and Tonic", "Refreshing gin cocktail.", 3, 1, false, new List<Ingredient> { new Ingredient(50, "Gin", "ml"), new Ingredient(150, "Tonic Water", "ml"), new Ingredient(1, "Lime Wedge", "unit") }, new List<string> { "Mix gin and tonic", "Add lime" }, true, TEMPERATURE.Cold),
            new Drink("Bloody Mary", "Spicy tomato juice cocktail with vodka.", 8, 1, false, new List<Ingredient> { new Ingredient(50, "Vodka", "ml"), new Ingredient(200, "Tomato Juice", "ml"), new Ingredient(1, "Celery Stalk", "unit") }, new List<string> { "Mix ingredients", "Garnish" }, true, TEMPERATURE.Cold),
            new Drink("Chai Latte", "Spiced tea latte.", 8, 1, true, new List<Ingredient> { new Ingredient(150, "Chai Concentrate", "ml"), new Ingredient(150, "Milk", "ml") }, new List<string> { "Heat milk and chai", "Whisk" }, false, TEMPERATURE.Hot),
            new Drink("Coconut Water", "Natural coconut water.", 0, 1, true, new List<Ingredient> { new Ingredient(300, "Coconut Water", "ml") }, new List<string> { "Serve chilled" }, false, TEMPERATURE.Cold),
            new Drink("Mimosa", "Champagne and orange juice cocktail.", 2, 1, false, new List<Ingredient> { new Ingredient(100, "Champagne", "ml"), new Ingredient(100, "Orange Juice", "ml") }, new List<string> { "Combine chilled ingredients" }, true, TEMPERATURE.Cold),
            new Drink("Arnold Palmer", "Half iced tea, half lemonade.", 5, 1, true, new List<Ingredient> { new Ingredient(150, "Iced Tea", "ml"), new Ingredient(150, "Lemonade", "ml") }, new List<string> { "Mix well" }, false, TEMPERATURE.Cold),
            new Drink("Ginger Ale", "Carbonated ginger-flavored drink.", 0, 1, true, new List<Ingredient> { new Ingredient(330, "Ginger Ale", "ml") }, new List<string> { "Serve chilled" }, false, TEMPERATURE.Cold)
        };
        return drinks;
    }
    
}
    
