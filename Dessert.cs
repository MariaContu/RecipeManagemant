namespace RecipesManagement
{
    public class Dessert : Recipe
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
        List<Dessert> desserts = new List<Dessert> {};
        return desserts;
    }

        
    }
}
