namespace RecipesManagement;

using System.Xml;

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
            Console.WriteLine("2. Register ");
            Console.WriteLine("3. Out");
        
            isValidInput = int.TryParse(ReadLineNonNullable(), out choice);
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
            case 2: // Register a new recipe
                Console.Clear();
                Console.WriteLine("What would you like to register? ");
                Console.WriteLine("1. Main Dish \n2. Dessert \n3. Drink");
                    
                isValidInput = int.TryParse(ReadLineNonNullable(), out choice);
                if (!isValidInput || choice < 1 || choice > 3)
                {
                    Console.WriteLine("Invalid input. Please select a valid option.:");
                    Console.ReadKey();
                }
                switch (choice)
                {
                    case 1: // Main Dish: asks for user input for each property to create a new MainDish object
                        MainDish md = new MainDish();
                        Console.WriteLine("Give it a name: ");
                        md.Name = ReadLineNonNullable();
                        Console.WriteLine("Insert a description: ");
                        md.Description = ReadLineNonNullable();
                        Console.WriteLine("How long does it take to make? (In minutes)");
                        md.TimeInMinutes = int.Parse(ReadLineNonNullable());
                        Console.WriteLine("How many portions?");
                        md.Portions = int.Parse(ReadLineNonNullable());
                        Console.WriteLine("Is it vegetarian? (yes/no)");
                        md.IsVegetarian = ReadLineNonNullable() == "yes";
                        
                        Console.WriteLine("\nInsert a ingredient or 0 to exit: ");
                        string ingredient = "";
                        while (ingredient != "0")
                        {
                            ingredient = ReadLineNonNullable();
                            md.Ingredients.Add(ingredient);
                        }
                        
                        Console.WriteLine("\nInsert a instruction or 0 to exit: ");
                        string instruction = "";
                        while (instruction != "0")
                        {
                            instruction = ReadLineNonNullable();
                            md.Instructions.Add(instruction);
                        }

                        Console.WriteLine("\nWhich protein type is it? (Meat, Chicken, Fish, Chickpea, Soy, NA)");
                        string proteinInput = ReadLineNonNullable().ToLower();
                        if (Enum.TryParse(typeof(PROTEIN), proteinInput, true, out var protein))
                        {
                            md.ProteinType = (PROTEIN)protein;
                        }
                        else
                        {
                            Console.WriteLine("Invalid protein type. Setting to Not Available.");
                            md.ProteinType = PROTEIN.NA;
                        }

                        Console.WriteLine("\nWhich cuisine is it? (Italian, Indian, Mexican, Japanese, American, Thai, Brazilian, Other)");
                        string cuisineInput = ReadLineNonNullable().ToUpper();
                        if (Enum.TryParse(typeof(CUISINE), cuisineInput, true, out var cuisine))
                        {
                            md.CuisineType = (CUISINE)cuisine;
                        }
                        else
                        {
                            Console.WriteLine("Invalid cuisine type. Setting to Other.");
                            md.CuisineType = CUISINE.OTHER;
                        }

                        break;
                    case 2: // Dessert: asks for user input for each property to create a new Dessert object
                        Dessert des = new Dessert();
                        Console.WriteLine("Give it a name: ");
                        des.Name = ReadLineNonNullable();
                        Console.WriteLine("Insert a description: ");
                        des.Description = ReadLineNonNullable();
                        Console.WriteLine("How long does it take to make? (In minutes)");
                        des.TimeInMinutes = int.Parse(ReadLineNonNullable());
                        Console.WriteLine("How many portions?");
                        des.Portions = int.Parse(ReadLineNonNullable());
                        Console.WriteLine("Is it vegetarian? (yes/no)");
                        des.IsVegetarian = ReadLineNonNullable() == "yes";
                        
                        Console.WriteLine("\nInsert a ingredient or 0 to exit: ");
                        string ingredient1 = "";
                        while (ingredient1 != "0")
                        {
                            ingredient1 = ReadLineNonNullable();
                            des.Ingredients.Add(ingredient1);
                        }
                        
                        Console.WriteLine("\nInsert a instruction or 0 to exit: ");
                        string instruction1 = "";
                        while (instruction1 != "0")
                        {
                            instruction1 = ReadLineNonNullable();
                            des.Instructions.Add(instruction1);
                        }
                        
                        Console.WriteLine("\nIs it baked? (yes/no)");
                        des.IsBaked = ReadLineNonNullable() == "yes";
                        
                        Console.WriteLine("\nIs it gluten free? (yes/no)");
                        des.IsGlutenFree = ReadLineNonNullable() == "yes";

                        break;
                        
                    case 3: // Drink: asks for user input for each property to create a new Drink object
                        Drink drink = new Drink();
                        Console.WriteLine("Give it a name: ");
                        drink.Name = ReadLineNonNullable();
                        Console.WriteLine("Insert a description: ");
                        drink.Description = ReadLineNonNullable();
                        Console.WriteLine("How long does it take to make? (In minutes)");
                        drink.TimeInMinutes = int.Parse(ReadLineNonNullable());
                        Console.WriteLine("How many portions?");
                        drink.Portions = int.Parse(ReadLineNonNullable());
                        Console.WriteLine("Is it vegetarian? (yes/no)");
                        drink.IsVegetarian = ReadLineNonNullable() == "yes";
                        
                        Console.WriteLine("\nInsert a ingredient or 0 to exit: ");
                        string ingredient2 = "";
                        while (ingredient2 != "0")
                        {
                            ingredient2 = ReadLineNonNullable();
                            drink.Ingredients.Add(ingredient2);
                        }
                        
                        Console.WriteLine("\nInsert a instruction or 0 to exit: ");
                        string instruction2 = "";
                        while (instruction2 != "0")
                        {
                            instruction2= ReadLineNonNullable();
                            drink.Instructions.Add(instruction2);
                        }
                        
                        Console.WriteLine("\nIs it alcoholic? (yes/no)");
                        drink.IsAlcoholic = ReadLineNonNullable() == "yes";
                        
                        Console.WriteLine("\nWhat is the temperature? (hot/cold/ambient)");
                        string temperatureInput = ReadLineNonNullable().ToLower();
                        if (Enum.TryParse(typeof(TEMPERATURE), temperatureInput, true, out var temperature))
                        {
                            drink.Temperature = (TEMPERATURE)temperature;
                        }
                        
                        break; 
                }
                break;
            case 3:
                Console.Clear();
                Environment.Exit(0);
                break;
        }
    }

    private static void ShowCategories()
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
        
            isValidInput = int.TryParse(ReadLineNonNullable(), out choice);
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
                Console.Clear();
                Environment.Exit(0);
                break;
        }
    }

    public interface IOptionItem
    {
        string Name { get; }
        void DisplayDetails();
    }
    private static void ShowOptions<T>(List<T> options) where T : IOptionItem
    {
        int i = 1;
        options.ForEach(o => Option.AddOption(i++, o.Name));
        Option.AddOption(i, "Return");

        int chosenOption = Option.ChooseOption("Type the wanted option: ");
        if (chosenOption <= options.Count)
        {
            ShowRecipe(options[chosenOption - 1]);
        }
        else
        {
            ShowCategories();
        }
    }
    private static void ShowRecipe<T>(T recipe) where T : IOptionItem
    {
        recipe.DisplayDetails();
        Option.AddOption(1, "Return");
        int chosenOption = Option.ChooseOption("Type the wanted option: ");
        if (chosenOption == 1)
        {
            ShowCategories();
        }
    }
    
    private static string ReadLineNonNullable()
    {
        while (true) //
        {
            string? input = Console.ReadLine();
        
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input; 
            }
        
            Console.WriteLine("Invalid input. Please select a valid input.");
        }
    }
}

