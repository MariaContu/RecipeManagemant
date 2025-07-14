using System.Xml;

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
                
                // dar opcao de mostrar tudo ou filtrar por proteina ou tipo de cozinha
                Console.WriteLine("\n\n Choose the option that satisfies you the most:");
                Console.WriteLine("1. Filter by PROTEIN TYPE\n2. Filter by CUISINE TYPE\n3. Show ALL");
                
                isValidInput = int.TryParse(Console.ReadLine(), out choice);
                if (!isValidInput || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Invalid input. Please select a valid option.:");
                    Console.ReadKey();
                }
                
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        PROTEIN DesiredProtein = ShowProteinTypes();
                        List<MainDish> filteredByProtein = mainDishes.Where(x => x.ProteinType == DesiredProtein).ToList();
                        ShowOptions(filteredByProtein);
                        
                        break;
                    case 2:
                        Console.Clear();
                        CUISINE DesiredCuisine = ShowCuisineTypes();
                        List<MainDish> filteredByCuisine = mainDishes.Where(x => x.CuisineType == DesiredCuisine).ToList();
                        ShowOptions(filteredByCuisine);
                        
                        break;
                    case 3:
                        ShowOptions(mainDishes);
                        break;
                }
                break;
            case 2:
                List<Dessert> desserts = Dessert.GenerateDesserts();

                // dar opcao de mostrar tudo ou filtrar por proteina ou tipo de cozinha
                Console.WriteLine("\n\n Choose the option that satisfies you the most:");
                Console.WriteLine("1. Filter by GLUTEN\n2. Filter by BAKED\n3. Show ALL");
                
                isValidInput = int.TryParse(Console.ReadLine(), out choice);
                if (!isValidInput || choice < 1 || choice > 3)
                {
                    Console.WriteLine("Invalid input. Please select a valid option.:");
                    Console.ReadKey();
                }
                
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Do you want it GLUTEN FREE?\n1. YES\n2. NO");
                        
                        isValidInput = int.TryParse(Console.ReadLine(), out choice);
                        if (!isValidInput || choice < 1 || choice > 2)
                        {
                            Console.WriteLine("Invalid input. Please select a valid option.:");
                            Console.ReadKey();
                        }
                        
                        //switch com yes ou no
                        switch (choice)
                        {
                            case 1:
                                //com gluten
                                List<Dessert> filteredByGluten = desserts.Where(d => d.IsGlutenFree == false).ToList();
                                ShowOptions(filteredByGluten);
                                
                                break;
                            case 2:
                                List<Dessert> filteredByGlutenFree = desserts.Where(d => d.IsGlutenFree == true).ToList();
                                ShowOptions(filteredByGlutenFree);
                                break;
                        }
                        
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Do you want it baked?\n1. YES\n2. NO");
                        
                        isValidInput = int.TryParse(Console.ReadLine(), out choice);
                        if (!isValidInput || choice < 1 || choice > 2)
                        {
                            Console.WriteLine("Invalid input. Please select a valid option.:");
                            Console.ReadKey();
                        }
                        
                        //switch com yes ou no
                        switch (choice)
                        {
                            case 1:
                                //baked
                                List<Dessert> filterByBaked = desserts.Where(d => d.IsBaked == true).ToList();
                                ShowOptions(filterByBaked);
                                
                                break;
                            case 2:
                                //not baked
                                List<Dessert> filterByNotBaked = desserts.Where(d => d.IsBaked == false).ToList();
                                ShowOptions(filterByNotBaked);
                                break;
                        }
                        
                        break;
                    case 3:
                        ShowOptions(desserts);
                        break;
                }
                break;
            case 3:
                List<Drink> drinks = Drink.GenerateDrinks();
                
                // dar opcao de mostrar tudo ou filtrar por proteina ou tipo de cozinha
                Console.WriteLine("\n\n Choose the option that satisfies you the most:");
                Console.WriteLine("1. Filter by ALCOHOL\n2. Filter by TEMPERATURE\n3. Show ALL");
                
                isValidInput = int.TryParse(Console.ReadLine(), out choice);
                if (!isValidInput || choice < 1 || choice > 3)
                {
                    Console.WriteLine("Invalid input. Please select a valid option.:");
                    Console.ReadKey();
                }
                
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Do you want it WITH ALCOHOL?\n1. YES\n2. NO");
                        
                        isValidInput = int.TryParse(Console.ReadLine(), out choice);
                        if (!isValidInput || choice < 1 || choice > 2)
                        {
                            Console.WriteLine("Invalid input. Please select a valid option.:");
                            Console.ReadKey();
                        }
                        
                        //switch com yes ou no
                        switch (choice)
                        {
                            case 1:
                                //with alcohol
                                List<Drink> filteredByWithAlcohol = drinks.Where(d => d.IsAlcoholic == true).ToList();
                                ShowOptions(filteredByWithAlcohol);
                                break;
                            case 2:
                                List<Drink> filteredByNoAlcohol = drinks.Where(d => d.IsAlcoholic == false).ToList();
                                ShowOptions(filteredByNoAlcohol);
                                break;
                        }
                        
                        break;
                    case 2:
                        Console.Clear();
                        TEMPERATURE temperature = ShowTemperatureTypes();
                        List<Drink> filteredByTemperature = drinks.Where(d => d.Temperature == temperature).ToList();
                        ShowOptions(filteredByTemperature);
                        
                        break;
                    case 3:
                        ShowOptions(drinks);
                        break;
                }
                
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
    
    public static PROTEIN ShowProteinTypes()
    {
        int choice;
        bool isValidInput;
        PROTEIN selectedProtein = PROTEIN.NA;

        do
        {
            Console.Clear();
            Console.WriteLine("Select a Protein Type to filter:");
            string[] proteinNames = Enum.GetNames(typeof(PROTEIN));
            for (int i = 0; i < proteinNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {proteinNames[i]}");
            }
            Console.Write("Enter your choice: ");

            isValidInput = int.TryParse(Console.ReadLine(), out choice);

            if (isValidInput && choice >= 1 && choice <= proteinNames.Length)
            {
                selectedProtein = (PROTEIN)Enum.Parse(typeof(PROTEIN), proteinNames[choice - 1]);
            }
            else
            {
                Console.WriteLine("Invalid input. Please select a valid option.");
                Console.ReadKey();
            }
        } while (!isValidInput || choice < 1 || choice > Enum.GetNames(typeof(PROTEIN)).Length);

        return selectedProtein;
    }
    
    public static CUISINE ShowCuisineTypes()
    {
        int choice;
        bool isValidInput;
        CUISINE selectedCuisine = CUISINE.OTHER;

        do
        {
            Console.Clear();
            Console.WriteLine("Select a Cuisine Type to filter:");
            string[] cuisineNames = Enum.GetNames(typeof(CUISINE));
            for (int i = 0; i < cuisineNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {cuisineNames[i]}");
            }
            Console.Write("Enter your choice: ");

            isValidInput = int.TryParse(Console.ReadLine(), out choice);

            if (isValidInput && choice >= 1 && choice <= cuisineNames.Length)
            {
                selectedCuisine = (CUISINE)Enum.Parse(typeof(CUISINE), cuisineNames[choice - 1]);
            }
            else
            {
                Console.WriteLine("Invalid input. Please select a valid option.");
                Console.ReadKey();
            }
        } while (!isValidInput || choice < 1 || choice > Enum.GetNames(typeof(CUISINE)).Length);

        return selectedCuisine;
    }
    
    public static TEMPERATURE ShowTemperatureTypes()
    {
        int choice;
        bool isValidInput;
        TEMPERATURE selectedTemperature = TEMPERATURE.COLD; // Valor padrão

        do
        {
            Console.Clear();
            Console.WriteLine("Select a Temperature Type to filter:");
            string[] temperatureNames = Enum.GetNames(typeof(TEMPERATURE));
            for (int i = 0; i < temperatureNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {temperatureNames[i]}");
            }
            Console.Write("Enter your choice: ");

            isValidInput = int.TryParse(Console.ReadLine(), out choice);

            if (isValidInput && choice >= 1 && choice <= temperatureNames.Length)
            {
                selectedTemperature = (TEMPERATURE)Enum.Parse(typeof(TEMPERATURE), temperatureNames[choice - 1]);
            }
            else
            {
                Console.WriteLine("Invalid input. Please select a valid option.");
                Console.ReadKey();
            }
        } while (!isValidInput || choice < 1 || choice > Enum.GetNames(typeof(TEMPERATURE)).Length);

        return selectedTemperature;
    }

}

