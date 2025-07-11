namespace RecipesManagement
{
    public class Dessert : Recipe
    {
        private bool IsGlutenFree;
        private bool IsBaked;

        public Dessert(bool IsGlutenFree, bool IsBaked, string name, string description, int timeInMinutes, double portions, bool isVegetarian, List<Ingredient> ingredients,
                List<string> instructions) : base(name, description, timeInMinutes, portions, isVegetarian, List < Ingredient > ingredients, instructions)
        {
            this.IsGlutenFree = IsGlutenFree;
            this.IsBaked = IsBaked;
        }

            
        public override void DisplayDetails()
        {
            PrintRecipe();
            Console.WriteLine($"Is gluten free? {(IsGlutenFree ? "Yes" : "No")}");
            Console.WriteLine($"Is baked?: {(IsBaked ? "Yes" : "No")}");
        }
    }
}
