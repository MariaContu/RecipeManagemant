namespace RecipesManagement
{
    public class Dessert : Recipe
    {
        private bool IsGlutenFree { get; set; }
        private bool IsBaked { get; set; }

        public Dessert(bool IsGlutenFree, bool IsBaked, string name, string description, int timeInMinutes, double portions, bool isVegetarian, List<Ingredient> ingredients,
                List<string> instructions) : base(name, description, timeInMinutes, portions, isVegetarian, ingredients, instructions)
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
