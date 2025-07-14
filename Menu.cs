using System.Xml;

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
                //show list of categories
                break;
            case 2: // Register a new recipe
                Console.WriteLine("What would you like to register? ");
                Console.WriteLine("1. Main Dish \n2. Dessert \n3. Drink");
                    
                isValidInput = int.TryParse(Console.ReadLine(), out choice);
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
                        md.Name = Console.ReadLine();
                        Console.WriteLine("Insert a description: ");
                        md.Description = Console.ReadLine();
                        Console.WriteLine("How long does it take to make? (In minutes)");
                        md.TimeInMinutes = int.Parse(Console.ReadLine());
                        Console.WriteLine("How many portions?");
                        md.Portions = int.Parse(Console.ReadLine());
                        Console.WriteLine("Is it vegetarian? (yes/no)");
                        md.IsVegetarian = Console.ReadLine() == "yes";
                        
                        Console.WriteLine("Insert a ingredient or 0 to exit: ");
                        string ingredient = "";
                        while (ingredient != "0")
                        {
                            ingredient = Console.ReadLine();
                            md.Ingredients.Add(ingredient);
                        }
                        
                        Console.WriteLine("Insert a instruction or 0 to exit: ");
                        string instruction = "";
                        while (instruction != "0")
                        {
                            instruction = Console.ReadLine();
                            md.Instructions.Add(instruction);
                        }

                        Console.WriteLine("Which protein type is it? (Meat, Chicken, Fish, Chickpea, Soy, NA)");
                        string proteinInput = Console.ReadLine().ToLower();
                        if (Enum.TryParse(typeof(PROTEIN), proteinInput, true, out var protein))
                        {
                            md.ProteinType = (PROTEIN)protein;
                        }
                        else
                        {
                            Console.WriteLine("Invalid protein type. Setting to Not Available.");
                            md.ProteinType = PROTEIN.NA;
                        }

                        Console.WriteLine("Which cuisine is it? (Italian, Indian, Mexican, Japanese, American, Thai, Brazilian, Other)");
                        string cuisineInput = Console.ReadLine().ToUpper();
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
                        des.Name = Console.ReadLine();
                        Console.WriteLine("Insert a description: ");
                        des.Description = Console.ReadLine();
                        Console.WriteLine("How long does it take to make? (In minutes)");
                        des.TimeInMinutes = int.Parse(Console.ReadLine());
                        Console.WriteLine("How many portions?");
                        des.Portions = int.Parse(Console.ReadLine());
                        Console.WriteLine("Is it vegetarian? (yes/no)");
                        des.IsVegetarian = Console.ReadLine() == "yes";
                        
                        Console.WriteLine("Insert a ingredient or 0 to exit: ");
                        string ingredient1 = "";
                        while (ingredient1 != "0")
                        {
                            ingredient1 = Console.ReadLine();
                            des.Ingredients.Add(ingredient1);
                        }
                        
                        Console.WriteLine("Insert a instruction or 0 to exit: ");
                        string instruction1 = "";
                        while (instruction1 != "0")
                        {
                            instruction1 = Console.ReadLine();
                            des.Instructions.Add(instruction1);
                        }
                        
                        Console.WriteLine("Is it baked? (yes/no)");
                        des.IsBaked = Console.ReadLine() == "yes";
                        
                        Console.WriteLine("Is it gluten free? (yes/no)");
                        des.IsGlutenFree = Console.ReadLine() == "yes";

                        break;
                        
                    case 3: // Drink: asks for user input for each property to create a new Drink object
                        Drink drink = new Drink();
                        Console.WriteLine("Give it a name: ");
                        drink.Name = Console.ReadLine();
                        Console.WriteLine("Insert a description: ");
                        drink.Description = Console.ReadLine();
                        Console.WriteLine("How long does it take to make? (In minutes)");
                        drink.TimeInMinutes = int.Parse(Console.ReadLine());
                        Console.WriteLine("How many portions?");
                        drink.Portions = int.Parse(Console.ReadLine());
                        Console.WriteLine("Is it vegetarian? (yes/no)");
                        drink.IsVegetarian = Console.ReadLine() == "yes";
                        
                        Console.WriteLine("Insert a ingredient or 0 to exit: ");
                        string ingredient2 = "";
                        while (ingredient2 != "0")
                        {
                            ingredient2 = Console.ReadLine();
                            drink.Ingredients.Add(ingredient2);
                        }
                        
                        Console.WriteLine("Insert a instruction or 0 to exit: ");
                        string instruction2 = "";
                        while (instruction2 != "0")
                        {
                            instruction2= Console.ReadLine();
                            drink.Instructions.Add(instruction2);
                        }
                        
                        Console.WriteLine("Is it alcoholic? (yes/no)");
                        drink.IsAlcoholic = Console.ReadLine() == "yes";
                        
                        Console.WriteLine("What is the temperature? (hot/cold/ambient)");
                        string temperatureInput = Console.ReadLine().ToLower();
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
}