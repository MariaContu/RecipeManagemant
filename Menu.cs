namespace RecipesManagement;

public class Menu
{
    public static void ShowMainMenu()
    {
        int choice;
        bool isValidInput;

        do
        {
            Console.Clear();
            Console.WriteLine("\t╔══════════════════╗");
            Console.WriteLine("\t║   RICA PANCITA   ║");
            Console.WriteLine("\t╚══════════════════╝");
            Console.WriteLine("\tBrazilian Restaurant");
            Console.WriteLine("1. Categories ");
            Console.WriteLine("2. Soborô");
            Console.WriteLine("3. Out");
        
            isValidInput = int.TryParse(Console.ReadLine(), out choice);
            if (!isValidInput || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input. Please select a valid option.:");
                Console.ReadKey();
            }
        } while (!isValidInput || choice < 1 || choice > 3);

        switch (choice)
        {
            case 1:
                //show list of categories
                break;
            case 2:
                //show list of ingredients in order to display possible recipies
                //each ingredient is added on a list, which is used to find recipies that has all those ingredients
                //
                //from recipie in recipies (all this in var query)
                //select new {
                //      RecipeName = recipe.Name,
                //      Ingredients = from ingredient in recipe.Ingredients
                //                    select ingredient.Name
                //}
                break;
            case 3:
                Console.Clear();
                Environment.Exit(0);
                break;
        }
    }
}