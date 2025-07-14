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
        List<Drink> drinks = new List<Drink>
        {
            new Drink("Water", "Plain drinking water.", 0, 1, true, 
                new List<string> { "Water" }, 
                new List<string> { "Serve" }, false, TEMPERATURE.COLD),

            new Drink("Coffee", "Hot black coffee.", 5, 1, true, 
                new List<string> { "Coffee Beans", "Water" }, 
                new List<string> { "Brew coffee" }, false, TEMPERATURE.HOT),

            new Drink("Iced Tea", "Refreshing iced tea with lemon.", 10, 1, true, 
                new List<string> { "Tea Bag", "Water", "Ice" }, 
                new List<string> { "Brew tea", "Chill", "Add ice" }, false, TEMPERATURE.COLD),

            new Drink("Orange Juice", "Freshly squeezed orange juice.", 5, 1, true, 
                new List<string> { "Oranges" }, 
                new List<string> { "Squeeze oranges" }, false, TEMPERATURE.COLD),

            new Drink("Milkshake", "Creamy vanilla milkshake.", 5, 1, true, 
                new List<string> { "Milk", "Vanilla Ice Cream" }, 
                new List<string> { "Blend ingredients" }, false, TEMPERATURE.COLD),

            new Drink("Mojito", "Classic Cuban cocktail with rum and mint.", 10, 1, false, 
                new List<string> { "Rum", "Mint Leaves", "Lime", "Soda Water" }, 
                new List<string> { "Muddle mint and lime", "Add rum and ice", "Top with soda" }, true, TEMPERATURE.COLD),

            new Drink("Lemonade", "Sweet and sour homemade lemonade.", 15, 4, true, 
                new List<string> { "Lemons", "Sugar", "Water" }, 
                new List<string> { "Squeeze lemons", "Dissolve sugar", "Mix with water" }, false, TEMPERATURE.COLD),

            new Drink("Hot Chocolate", "Rich and creamy hot chocolate.", 10, 1, true, 
                new List<string> { "Milk", "Cocoa Powder", "Sugar" }, 
                new List<string> { "Heat milk", "Whisk in cocoa and sugar" }, false, TEMPERATURE.HOT),

            new Drink("Smoothie", "Healthy berry smoothie.", 5, 1, true, 
                new List<string> { "Mixed Berries", "Yogurt", "Milk" }, 
                new List<string> { "Blend all ingredients" }, false, TEMPERATURE.COLD),

            new Drink("Espresso", "Strong, concentrated coffee shot.", 2, 1, true, 
                new List<string> { "Coffee Grounds", "Water" }, 
                new List<string> { "Brew under pressure" }, false, TEMPERATURE.HOT),

            new Drink("Margarita", "Classic tequila-based cocktail.", 5, 1, false, 
                new List<string> { "Tequila", "Lime Juice", "Triple Sec" }, 
                new List<string> { "Shake with ice", "Serve in salt-rimmed glass" }, true, TEMPERATURE.COLD),

            new Drink("Green Tea", "Healthy brewed green tea.", 5, 1, true, 
                new List<string> { "Green Tea Bag", "Hot Water" }, 
                new List<string> { "Steep tea bag" }, false, TEMPERATURE.HOT),

            new Drink("Coke", "Carbonated soft drink.", 0, 1, true, 
                new List<string> { "Cola" }, 
                new List<string> { "Serve chilled" }, false, TEMPERATURE.COLD),

            new Drink("Latte", "Coffee with steamed milk and a layer of foam.", 7, 1, true, 
                new List<string> { "Espresso", "Milk" }, 
                new List<string> { "Brew espresso", "Steam milk", "Combine" }, false, TEMPERATURE.HOT),

            new Drink("Gin and Tonic", "Refreshing gin cocktail.", 3, 1, false, 
                new List<string> { "Gin", "Tonic Water", "Lime Wedge" }, 
                new List<string> { "Mix gin and tonic", "Add lime" }, true, TEMPERATURE.COLD),

            new Drink("Bloody Mary", "Spicy tomato juice cocktail with vodka.", 8, 1, false, 
                new List<string> { "Vodka", "Tomato Juice", "Celery Stalk" }, 
                new List<string> { "Mix ingredients", "Garnish" }, true, TEMPERATURE.COLD),

            new Drink("Chai Latte", "Spiced tea latte.", 8, 1, true, 
                new List<string> { "Chai Concentrate", "Milk" }, 
                new List<string> { "Heat milk and chai", "Whisk" }, false, TEMPERATURE.HOT),

            new Drink("Coconut Water", "Natural coconut water.", 0, 1, true, 
                new List<string> { "Coconut Water" }, 
                new List<string> { "Serve chilled" }, false, TEMPERATURE.COLD),

            new Drink("Mimosa", "Champagne and orange juice cocktail.", 2, 1, false, 
                new List<string> { "Champagne", "Orange Juice" }, 
                new List<string> { "Combine chilled ingredients" }, true, TEMPERATURE.COLD),

            new Drink("Arnold Palmer", "Half iced tea, half lemonade.", 5, 1, true, 
                new List<string> { "Iced Tea", "Lemonade" }, 
                new List<string> { "Mix well" }, false, TEMPERATURE.COLD),

            new Drink("Ginger Ale", "Carbonated ginger-flavored drink.", 0, 1, true, 
                new List<string> { "Ginger Ale" }, 
                new List<string> { "Serve chilled" }, false, TEMPERATURE.COLD)
        };

        return drinks;
    }

    
}
    
