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
            Console.WriteLine("3. Leave");
        
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
                ShowCategories();
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

    public static void ShowCategories()
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
            Console.WriteLine("1. Main dishes ");
            Console.WriteLine("2. Dessert ");
            Console.WriteLine("3. Drinks ");
            Console.WriteLine("4. Leave ");
        
            isValidInput = int.TryParse(Console.ReadLine(), out choice);
            if (!isValidInput || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid input. Please select a valid option.:");
                Console.ReadKey();
            }
        } while (!isValidInput || choice < 1 || choice > 4);
        
        switch (choice)
        {
            case 1:
                List<MainDish> mainDishes = MainDish.GenerateMainDishes();
                ShowOptions(mainDishes);
                break;
            case 2:
                List<Dessert> desserts = Dessert.GenerateDesserts();
                ShowOptions(desserts);
                break;
            case 3:
                List<Drink> drinks = Drink.GenerateDrinks();
                ShowOptions(drinks);
                break;
            case 4:
                Environment.Exit(0);
                break;
        }
    }

    public interface IOptionItem
    {
        string Name { get; }
        void DisplayDetails();
    }
    public static void ShowOptions<T>(List<T> options) where T : IOptionItem
    {
        int i = 1;
        options.ForEach(o => Option.AddOption(i++, o.Name));

        int chosenOption = Option.ChooseOption("Digite o número da opção desejada: ");
        options[chosenOption-1].DisplayDetails();
    }
}