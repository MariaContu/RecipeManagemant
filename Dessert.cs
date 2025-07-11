namespace RecipesManagement
{
    public class Dessert : Recipe
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
    }
}
