namespace RecipesManagement
{
    public class Dessert : Recipe, Menu.IOptionItem
    {
        public bool IsGlutenFree { get; set; }
        public bool IsBaked { get; set; }

        public Dessert(string name, string description, int timeInMinutes, double portions, bool isVegetarian, List<string> ingredients,
                List<string> instructions, bool IsGlutenFree, bool IsBaked) : base(name, description, timeInMinutes, portions, isVegetarian, ingredients, instructions)
        {
            this.IsGlutenFree = IsGlutenFree;
            this.IsBaked = IsBaked;
        }

        public Dessert()
        {
            
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
                new Dessert("Chocolate Cake", "A rich, moist chocolate cake.", 60, 8, false, 
                    new List<string> { "Flour", "Sugar", "Cocoa Powder", "Eggs" }, 
                    new List<string> { "Mix ingredients", "Bake for 30 min" }, false, true),

                new Dessert("Apple Pie", "Classic apple pie with a flaky crust.", 90, 6, true, 
                    new List<string> { "Apples", "Flour", "Butter" }, 
                    new List<string> { "Prepare crust", "Fill with apples", "Bake" }, false, true),

                new Dessert("Cheesecake", "Creamy New York style cheesecake.", 180, 10, true, 
                    new List<string> { "Cream Cheese", "Sugar", "Eggs" }, 
                    new List<string> { "Mix cream cheese", "Bake slowly" }, false, true),

                new Dessert("Brownies", "Fudgy chocolate brownies.", 45, 12, true, 
                    new List<string> { "Butter", "Sugar", "Eggs", "Cocoa Powder" }, 
                    new List<string> { "Melt butter", "Mix", "Bake" }, false, true),

                new Dessert("Panna Cotta", "Silky smooth Italian dessert.", 240, 4, true, 
                    new List<string> { "Cream", "Sugar", "Gelatin" }, 
                    new List<string> { "Heat cream", "Dissolve gelatin", "Chill" }, false, false),

                new Dessert("Lemon Meringue Pie", "Tangy lemon filling with a sweet meringue topping.", 120, 8, true, 
                    new List<string> { "Lemons", "Eggs", "Sugar" }, 
                    new List<string> { "Make lemon curd", "Prepare meringue", "Assemble and bake" }, false, true),

                new Dessert("Tiramisu", "Classic Italian coffee-flavored dessert.", 180, 6, false, 
                    new List<string> { "Mascarpone", "Eggs", "Sugar", "Coffee" }, 
                    new List<string> { "Whip cream", "Dip ladyfingers", "Layer" }, false, false),

                new Dessert("Red Velvet Cake", "Vibrant red cake with cream cheese frosting.", 75, 10, true, 
                    new List<string> { "Flour", "Sugar", "Butter", "Eggs" }, 
                    new List<string> { "Mix dry ingredients", "Add wet", "Bake" }, false, true),

                new Dessert("Mousse au Chocolat", "Light and airy chocolate mousse.", 180, 4, true, 
                    new List<string> { "Dark Chocolate", "Eggs", "Sugar" }, 
                    new List<string> { "Melt chocolate", "Whip eggs", "Fold" }, false, false),

                new Dessert("Creme Brulee", "Rich custard base topped with a layer of hardened caramelized sugar.", 60, 4, true, 
                    new List<string> { "Cream", "Egg Yolks", "Sugar" }, 
                    new List<string> { "Infuse cream", "Mix yolks", "Bake in water bath" }, false, true),

                new Dessert("Carrot Cake", "Moist spiced cake with grated carrots and cream cheese frosting.", 70, 8, true, 
                    new List<string> { "Carrots", "Flour", "Sugar", "Eggs" }, 
                    new List<string> { "Mix wet", "Add dry", "Bake" }, false, true),

                new Dessert("Pavlova", "Crisp meringue with a soft, marshmallow-like center, topped with fruit.", 90, 6, true, 
                    new List<string> { "Egg Whites", "Sugar", "Berries" }, 
                    new List<string> { "Whip egg whites", "Fold sugar", "Bake slowly" }, true, true),

                new Dessert("Fruit Tart", "Sweet pastry crust filled with pastry cream and fresh fruit.", 120, 8, true, 
                    new List<string> { "Flour", "Butter", "Mixed Fruit" }, 
                    new List<string> { "Prepare crust", "Make pastry cream", "Assemble" }, false, true),

                new Dessert("Chocolate Chip Cookies", "Classic soft and chewy cookies.", 30, 24, true, 
                    new List<string> { "Butter", "Sugar", "Egg", "Chocolate Chips" }, 
                    new List<string> { "Cream butter and sugar", "Add egg", "Fold in flour and chips", "Bake" }, false, true),

                new Dessert("Banana Bread", "Moist, sweet bread made with ripe bananas.", 60, 8, true, 
                    new List<string> { "Bananas", "Flour", "Sugar", "Egg" }, 
                    new List<string> { "Mash bananas", "Mix wet", "Add dry", "Bake" }, false, true),

                new Dessert("S'mores", "Toasted marshmallow and chocolate sandwiched between graham crackers.", 10, 4, true, 
                    new List<string> { "Marshmallows", "Chocolate Squares", "Graham Crackers" }, 
                    new List<string> { "Toast marshmallow", "Assemble" }, false, false),

                new Dessert("Key Lime Pie", "Tart and refreshing pie with a graham cracker crust.", 90, 8, true, 
                    new List<string> { "Limes", "Sweetened Condensed Milk", "Graham Cracker Crumbs" }, 
                    new List<string> { "Mix filling", "Pour into crust", "Chill" }, false, false),

                new Dessert("Rice Pudding", "Creamy and comforting rice pudding.", 60, 4, true, 
                    new List<string> { "Rice", "Milk", "Sugar" }, 
                    new List<string> { "Simmer rice in milk", "Sweeten" }, false, false),

                new Dessert("Doughnuts", "Sweet, deep-fried pastry.", 90, 12, true, 
                    new List<string> { "Flour", "Sugar", "Yeast", "Egg" }, 
                    new List<string> { "Make dough", "Proof", "Fry" }, false, true),

                new Dessert("Peach Cobbler", "Sweet peaches topped with a biscuit-like topping.", 70, 6, true, 
                    new List<string> { "Peaches", "Flour", "Sugar", "Butter" }, 
                    new List<string> { "Prepare peaches", "Make topping", "Bake" }, false, true),

                new Dessert("Eclairs", "Choux pastry filled with cream and topped with icing.", 120, 8, true, 
                    new List<string> { "Flour", "Butter", "Eggs", "Pastry Cream" }, 
                    new List<string> { "Make choux pastry", "Bake", "Fill", "Ice" }, false, true)
            };

        return desserts;
    }


        
    }
}
