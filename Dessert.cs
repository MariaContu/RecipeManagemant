namespace RecipesManagement
{
    public class Dessert : Recipe, Menu.IOptionItem
    {
        private bool IsGlutenFree { get; set; }
        private bool IsBaked { get; set; }

        public Dessert(string name, string description, int timeInMinutes, double portions, bool isVegetarian, List<Ingredient> ingredients,
                List<string> instructions, bool IsGlutenFree, bool IsBaked) : base(name, description, timeInMinutes, portions, isVegetarian, ingredients, instructions)
        {
            this.IsGlutenFree = IsGlutenFree;
            this.IsBaked = IsBaked;
        }

            
        public override void DisplayDetails()
        {
            PrintRecipe();
            Console.WriteLine($"Is gluten free? {(IsGlutenFree ? "Yes" : "No")}");
            Console.WriteLine($"Is baked? {(IsBaked ? "Yes" : "No")}");
        }
        
        public static List<Dessert> GenerateDesserts()
    {
        List<Dessert> desserts = new List<Dessert>
        {
            new Dessert("Chocolate Cake", "A rich, moist chocolate cake.", 60, 8, false, new List<Ingredient> { new Ingredient(200, "Flour", "g"), new Ingredient(300, "Sugar", "g"), new Ingredient(50, "Cocoa Powder", "g"), new Ingredient(4, "Eggs", "units") }, new List<string> { "Mix ingredients", "Bake for 30 min" }, false, true),
            new Dessert("Apple Pie", "Classic apple pie with a flaky crust.", 90, 6, true, new List<Ingredient> { new Ingredient(500, "Apples", "g"), new Ingredient(200, "Flour", "g"), new Ingredient(100, "Butter", "g") }, new List<string> { "Prepare crust", "Fill with apples", "Bake" }, false, true),
            new Dessert("Cheesecake", "Creamy New York style cheesecake.", 180, 10, true, new List<Ingredient> { new Ingredient(500, "Cream Cheese", "g"), new Ingredient(200, "Sugar", "g"), new Ingredient(3, "Eggs", "units") }, new List<string> { "Mix cream cheese", "Bake slowly" }, false, true),
            new Dessert("Brownies", "Fudgy chocolate brownies.", 45, 12, true, new List<Ingredient> { new Ingredient(150, "Butter", "g"), new Ingredient(200, "Sugar", "g"), new Ingredient(3, "Eggs", "units"), new Ingredient(100, "Cocoa Powder", "g") }, new List<string> { "Melt butter", "Mix", "Bake" }, false, true),
            new Dessert("Panna Cotta", "Silky smooth Italian dessert.", 240, 4, true, new List<Ingredient> { new Ingredient(500, "Cream", "ml"), new Ingredient(100, "Sugar", "g"), new Ingredient(10, "Gelatin", "g") }, new List<string> { "Heat cream", "Dissolve gelatin", "Chill" }, false, false),
            new Dessert("Lemon Meringue Pie", "Tangy lemon filling with a sweet meringue topping.", 120, 8, true, new List<Ingredient> { new Ingredient(4, "Lemons", "units"), new Ingredient(4, "Eggs", "units"), new Ingredient(300, "Sugar", "g") }, new List<string> { "Make lemon curd", "Prepare meringue", "Assemble and bake" }, false, true),
            new Dessert("Tiramisu", "Classic Italian coffee-flavored dessert.", 180, 6, false, new List<Ingredient> { new Ingredient(250, "Mascarpone", "g"), new Ingredient(3, "Eggs", "units"), new Ingredient(150, "Sugar", "g"), new Ingredient(200, "Coffee", "ml") }, new List<string> { "Whip cream", "Dip ladyfingers", "Layer" }, false, false),
            new Dessert("Red Velvet Cake", "Vibrant red cake with cream cheese frosting.", 75, 10, true, new List<Ingredient> { new Ingredient(250, "Flour", "g"), new Ingredient(200, "Sugar", "g"), new Ingredient(100, "Butter", "g"), new Ingredient(2, "Eggs", "units") }, new List<string> { "Mix dry ingredients", "Add wet", "Bake" }, false, true),
            new Dessert("Mousse au Chocolat", "Light and airy chocolate mousse.", 180, 4, true, new List<Ingredient> { new Ingredient(200, "Dark Chocolate", "g"), new Ingredient(4, "Eggs", "units"), new Ingredient(50, "Sugar", "g") }, new List<string> { "Melt chocolate", "Whip eggs", "Fold" }, false, false),
            new Dessert("Creme Brulee", "Rich custard base topped with a layer of hardened caramelized sugar.", 60, 4, true, new List<Ingredient> { new Ingredient(500, "Cream", "ml"), new Ingredient(4, "Egg Yolks", "units"), new Ingredient(100, "Sugar", "g") }, new List<string> { "Infuse cream", "Mix yolks", "Bake in water bath" }, false, true),
            new Dessert("Carrot Cake", "Moist spiced cake with grated carrots and cream cheese frosting.", 70, 8, true, new List<Ingredient> { new Ingredient(300, "Carrots", "g"), new Ingredient(200, "Flour", "g"), new Ingredient(150, "Sugar", "g"), new Ingredient(3, "Eggs", "units") }, new List<string> { "Mix wet", "Add dry", "Bake" }, false, true),
            new Dessert("Pavlova", "Crisp meringue with a soft, marshmallow-like center, topped with fruit.", 90, 6, true, new List<Ingredient> { new Ingredient(4, "Egg Whites", "units"), new Ingredient(200, "Sugar", "g"), new Ingredient(200, "Berries", "g") }, new List<string> { "Whip egg whites", "Fold sugar", "Bake slowly" }, true, true),
            new Dessert("Fruit Tart", "Sweet pastry crust filled with pastry cream and fresh fruit.", 120, 8, true, new List<Ingredient> { new Ingredient(200, "Flour", "g"), new Ingredient(100, "Butter", "g"), new Ingredient(300, "Mixed Fruit", "g") }, new List<string> { "Prepare crust", "Make pastry cream", "Assemble" }, false, true),
            new Dessert("Chocolate Chip Cookies", "Classic soft and chewy cookies.", 30, 24, true, new List<Ingredient> { new Ingredient(150, "Butter", "g"), new Ingredient(100, "Sugar", "g"), new Ingredient(1, "Egg", "unit"), new Ingredient(200, "Chocolate Chips", "g") }, new List<string> { "Cream butter and sugar", "Add egg", "Fold in flour and chips", "Bake" }, false, true),
            new Dessert("Banana Bread", "Moist, sweet bread made with ripe bananas.", 60, 8, true, new List<Ingredient> { new Ingredient(3, "Bananas", "units"), new Ingredient(200, "Flour", "g"), new Ingredient(100, "Sugar", "g"), new Ingredient(1, "Egg", "unit") }, new List<string> { "Mash bananas", "Mix wet", "Add dry", "Bake" }, false, true),
            new Dessert("S'mores", "Toasted marshmallow and chocolate sandwiched between graham crackers.", 10, 4, true, new List<Ingredient> { new Ingredient(4, "Marshmallows", "units"), new Ingredient(4, "Chocolate Squares", "units"), new Ingredient(8, "Graham Crackers", "units") }, new List<string> { "Toast marshmallow", "Assemble" }, false, false),
            new Dessert("Key Lime Pie", "Tart and refreshing pie with a graham cracker crust.", 90, 8, true, new List<Ingredient> { new Ingredient(4, "Limes", "units"), new Ingredient(1, "Sweetened Condensed Milk", "can"), new Ingredient(200, "Graham Cracker Crumbs", "g") }, new List<string> { "Mix filling", "Pour into crust", "Chill" }, false, false),
            new Dessert("Rice Pudding", "Creamy and comforting rice pudding.", 60, 4, true, new List<Ingredient> { new Ingredient(100, "Rice", "g"), new Ingredient(500, "Milk", "ml"), new Ingredient(50, "Sugar", "g") }, new List<string> { "Simmer rice in milk", "Sweeten" }, false, false),
            new Dessert("Doughnuts", "Sweet, deep-fried pastry.", 90, 12, true, new List<Ingredient> { new Ingredient(300, "Flour", "g"), new Ingredient(50, "Sugar", "g"), new Ingredient(10, "Yeast", "g"), new Ingredient(1, "Egg", "unit") }, new List<string> { "Make dough", "Proof", "Fry" }, false, true),
            new Dessert("Peach Cobbler", "Sweet peaches topped with a biscuit-like topping.", 70, 6, true, new List<Ingredient> { new Ingredient(500, "Peaches", "g"), new Ingredient(100, "Flour", "g"), new Ingredient(50, "Sugar", "g"), new Ingredient(50, "Butter", "g") }, new List<string> { "Prepare peaches", "Make topping", "Bake" }, false, true),
            new Dessert("Eclairs", "Choux pastry filled with cream and topped with icing.", 120, 8, true, new List<Ingredient> { new Ingredient(100, "Flour", "g"), new Ingredient(100, "Butter", "g"), new Ingredient(3, "Eggs", "units"), new Ingredient(300, "Pastry Cream", "g") }, new List<string> { "Make choux pastry", "Bake", "Fill", "Ice" }, false, true)
        };
        return desserts;
    }

        
    }
}
