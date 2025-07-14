using System.Xml;

namespace RecipesManagement;

using System;
using System.Collections.Generic;

public static class Menu
{
    static List<MainDish> _mainDishes = MainDish.GenerateMainDishes();
    static List<Dessert> _desserts = Dessert.GenerateDesserts();
    static List<Drink> _drinks = Drink.GenerateDrinks();
    
    public static void ShowMainMenu()
    {
        int choice;
        bool isValidInput;

        do
        {
            Console.Clear();
            Console.WriteLine("\t╔══════════════════╗");
            Console.WriteLine("\t║   RICA PANCITA   ║");
            Console.WriteLine("\t╚════════════════╝");
            Console.WriteLine("\tBrazilian Restaurant");
            Console.WriteLine("1. Categories ");
            Console.WriteLine("2. Register your own recipe ");
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
                int registerChoice;
                do
                {
                    Console.Clear();
                    Console.WriteLine("What would you like to register? ");
                    Console.WriteLine("1. Main Dish \n2. Dessert \n3. Drink");
                        
                    isValidInput = int.TryParse(ReadLineNonNullable(), out registerChoice);
                    if (!isValidInput || registerChoice < 1 || registerChoice > 3)
                    {
                        Console.WriteLine("Invalid input. Please select a valid option.:");
                        Console.ReadKey();
                    }
                } while (!isValidInput || registerChoice < 1 || registerChoice > 3);

                switch (registerChoice)
                {
                    case 1: 
                        MainDish md = new MainDish();
                        Console.WriteLine("Give it a name: ");
                        md.Name = ReadLineNonNullable();
                        Console.WriteLine("Insert a description: ");
                        md.Description = ReadLineNonNullable();
                        
                        int timeInMinutes;
                        do
                        {
                            Console.WriteLine("How long does it take to make? (In minutes)");
                            isValidInput = int.TryParse(ReadLineNonNullable(), out timeInMinutes);
                            if (!isValidInput || timeInMinutes <= 0)
                            {
                                Console.WriteLine("Invalid input. Please enter a positive number for minutes.");
                                Console.ReadKey();
                            }
                        } while (!isValidInput || timeInMinutes <= 0);
                        md.TimeInMinutes = timeInMinutes;

                        int portions;
                        do
                        {
                            Console.WriteLine("How many portions?");
                            isValidInput = int.TryParse(ReadLineNonNullable(), out portions);
                            if (!isValidInput || portions <= 0)
                            {
                                Console.WriteLine("Invalid input. Please enter a positive number for portions.");
                                Console.ReadKey();
                            }
                        } while (!isValidInput || portions <= 0);
                        md.Portions = portions;

                        string vegetarianInput;
                        do
                        {
                            Console.WriteLine("Is it vegetarian? (yes/no)");
                            vegetarianInput = ReadLineNonNullable().ToLower();
                            if (vegetarianInput != "yes" && vegetarianInput != "no")
                            {
                                Console.WriteLine("Invalid input. Please type 'yes' or 'no'.");
                                Console.ReadKey();
                            }
                        } while (vegetarianInput != "yes" && vegetarianInput != "no");
                        md.IsVegetarian = vegetarianInput == "yes";
                        
                        Console.WriteLine("\nInsert an ingredient or 0 to exit: ");
                        string ingredient = "";
                        while (ingredient != "0")
                        {
                            ingredient = ReadLineNonNullable();
                            if (ingredient != "0")
                            {
                                md.Ingredients.Add(ingredient);
                            }
                        }
                        
                        Console.WriteLine("\nInsert an instruction or 0 to exit: ");
                        string instruction = "";
                        while (instruction != "0")
                        {
                            instruction = ReadLineNonNullable();
                            if (instruction != "0")
                            {
                                md.Instructions.Add(instruction);
                            }
                        }

                        string proteinInput;
                        do
                        {
                            Console.WriteLine("\nWhich protein type is it? (Meat, Chicken, Fish, Chickpea, Soy, NA)");
                            proteinInput = ReadLineNonNullable().ToLower();
                            if (!Enum.TryParse(typeof(PROTEIN), proteinInput, true, out var protein))
                            {
                                Console.WriteLine("Invalid protein type. Please choose from the options.");
                                Console.ReadKey();
                            }
                            else
                            {
                                md.ProteinType = (PROTEIN)protein;
                                break;
                            }
                        } while (true);

                        string cuisineInput;
                        do
                        {
                            Console.WriteLine("\nWhich cuisine is it? (Italian, Indian, Mexican, Japanese, American, Thai, Brazilian, Other)");
                            cuisineInput = ReadLineNonNullable().ToUpper();
                            if (!Enum.TryParse(typeof(CUISINE), cuisineInput, true, out var cuisine))
                            {
                                Console.WriteLine("Invalid cuisine type. Please choose from the options.");
                                Console.ReadKey();
                            }
                            else
                            {
                                md.CuisineType = (CUISINE)cuisine;
                                break;
                            }
                        } while (true);

                        _mainDishes.Add(md);
                        ShowMainMenu();
                        break;
                    case 2:
                        Dessert des = new Dessert();
                        Console.WriteLine("Give it a name: ");
                        des.Name = ReadLineNonNullable();
                        Console.WriteLine("Insert a description: ");
                        des.Description = ReadLineNonNullable();
                        
                        do
                        {
                            Console.WriteLine("How long does it take to make? (In minutes)");
                            isValidInput = int.TryParse(ReadLineNonNullable(), out timeInMinutes);
                            if (!isValidInput || timeInMinutes <= 0)
                            {
                                Console.WriteLine("Invalid input. Please enter a positive number for minutes.");
                                Console.ReadKey();
                            }
                        } while (!isValidInput || timeInMinutes <= 0);
                        des.TimeInMinutes = timeInMinutes;

                        do
                        {
                            Console.WriteLine("How many portions?");
                            isValidInput = int.TryParse(ReadLineNonNullable(), out portions);
                            if (!isValidInput || portions <= 0)
                            {
                                Console.WriteLine("Invalid input. Please enter a positive number for portions.");
                                Console.ReadKey();
                            }
                        } while (!isValidInput || portions <= 0);
                        des.Portions = portions;

                        do
                        {
                            Console.WriteLine("Is it vegetarian? (yes/no)");
                            vegetarianInput = ReadLineNonNullable().ToLower();
                            if (vegetarianInput != "yes" && vegetarianInput != "no")
                            {
                                Console.WriteLine("Invalid input. Please type 'yes' or 'no'.");
                                Console.ReadKey();
                            }
                        } while (vegetarianInput != "yes" && vegetarianInput != "no");
                        des.IsVegetarian = vegetarianInput == "yes";
                        
                        Console.WriteLine("\nInsert an ingredient or 0 to exit: ");
                        string ingredient1 = "";
                        while (ingredient1 != "0")
                        {
                            ingredient1 = ReadLineNonNullable();
                            if (ingredient1 != "0")
                            {
                                des.Ingredients.Add(ingredient1);
                            }
                        }
                        
                        Console.WriteLine("\nInsert an instruction or 0 to exit: ");
                        string instruction1 = "";
                        while (instruction1 != "0")
                        {
                            instruction1 = ReadLineNonNullable();
                            if (instruction1 != "0")
                            {
                                des.Instructions.Add(instruction1);
                            }
                        }
                        
                        string bakedInput;
                        do
                        {
                            Console.WriteLine("\nIs it baked? (yes/no)");
                            bakedInput = ReadLineNonNullable().ToLower();
                            if (bakedInput != "yes" && bakedInput != "no")
                            {
                                Console.WriteLine("Invalid input. Please type 'yes' or 'no'.");
                                Console.ReadKey();
                            }
                        } while (bakedInput != "yes" && bakedInput != "no");
                        des.IsBaked = bakedInput == "yes";
                        
                        string glutenInput;
                        do
                        {
                            Console.WriteLine("\nIs it gluten free? (yes/no)");
                            glutenInput = ReadLineNonNullable().ToLower();
                            if (glutenInput != "yes" && glutenInput != "no")
                            {
                                Console.WriteLine("Invalid input. Please type 'yes' or 'no'.");
                                Console.ReadKey();
                            }
                        } while (glutenInput != "yes" && glutenInput != "no");
                        des.IsGlutenFree = glutenInput == "yes";

                        _desserts.Add(des);
                        ShowMainMenu();
                        break;
                    case 3:
                        Drink drink = new Drink();
                        Console.WriteLine("Give it a name: ");
                        drink.Name = ReadLineNonNullable();
                        Console.WriteLine("Insert a description: ");
                        drink.Description = ReadLineNonNullable();
                        
                        do
                        {
                            Console.WriteLine("How long does it take to make? (In minutes)");
                            isValidInput = int.TryParse(ReadLineNonNullable(), out timeInMinutes);
                            if (!isValidInput || timeInMinutes <= 0)
                            {
                                Console.WriteLine("Invalid input. Please enter a positive number for minutes.");
                                Console.ReadKey();
                            }
                        } while (!isValidInput || timeInMinutes <= 0);
                        drink.TimeInMinutes = timeInMinutes;

                        do
                        {
                            Console.WriteLine("How many portions?");
                            isValidInput = int.TryParse(ReadLineNonNullable(), out portions);
                            if (!isValidInput || portions <= 0)
                            {
                                Console.WriteLine("Invalid input. Please enter a positive number for portions.");
                                Console.ReadKey();
                            }
                        } while (!isValidInput || portions <= 0);
                        drink.Portions = portions;

                        do
                        {
                            Console.WriteLine("Is it vegetarian? (yes/no)");
                            vegetarianInput = ReadLineNonNullable().ToLower();
                            if (vegetarianInput != "yes" && vegetarianInput != "no")
                            {
                                Console.WriteLine("Invalid input. Please type 'yes' or 'no'.");
                                Console.ReadKey();
                            }
                        } while (vegetarianInput != "yes" && vegetarianInput != "no");
                        drink.IsVegetarian = vegetarianInput == "yes";
                        
                        Console.WriteLine("\nInsert an ingredient or 0 to exit: ");
                        string ingredient2 = "";
                        while (ingredient2 != "0")
                        {
                            ingredient2 = ReadLineNonNullable();
                            if (ingredient2 != "0")
                            {
                                drink.Ingredients.Add(ingredient2);
                            }
                        }
                        
                        Console.WriteLine("\nInsert an instruction or 0 to exit: ");
                        string instruction2 = "";
                        while (instruction2 != "0")
                        {
                            instruction2= ReadLineNonNullable();
                            if (instruction2 != "0")
                            {
                                drink.Instructions.Add(instruction2);
                            }
                        }
                        
                        string alcoholicInput;
                        do
                        {
                            Console.WriteLine("\nIs it alcoholic? (yes/no)");
                            alcoholicInput = ReadLineNonNullable().ToLower();
                            if (alcoholicInput != "yes" && alcoholicInput != "no")
                            {
                                Console.WriteLine("Invalid input. Please type 'yes' or 'no'.");
                                Console.ReadKey();
                            }
                        } while (alcoholicInput != "yes" && alcoholicInput != "no");
                        drink.IsAlcoholic = alcoholicInput == "yes";
                        
                        string temperatureInput;
                        do
                        {
                            Console.WriteLine("\nWhat is the temperature? (hot/cold/ambient)");
                            temperatureInput = ReadLineNonNullable().ToLower();
                            if (!Enum.TryParse(typeof(TEMPERATURE), temperatureInput, true, out var temperature))
                            {
                                Console.WriteLine("Invalid temperature type. Please choose from the options.");
                                Console.ReadKey();
                            }
                            else
                            {
                                drink.Temperature = (TEMPERATURE)temperature;
                                break;
                            }
                        } while (true);

                        _drinks.Add(drink);
                        ShowMainMenu();
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
            Console.WriteLine("\t╚════════════════╝");
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
                int filterChoiceMainDish;
                do
                {
                    Console.WriteLine("\n\n Choose the option that satisfies you the most:");
                    Console.WriteLine("1. Filter by PROTEIN TYPE\n2. Filter by CUISINE TYPE\n3. Show ALL");
                    
                    isValidInput = int.TryParse(Console.ReadLine(), out filterChoiceMainDish);
                    if (!isValidInput || filterChoiceMainDish < 1 || filterChoiceMainDish > 3)
                    {
                        Console.WriteLine("Invalid input. Please select a valid option.:");
                        Console.ReadKey();
                    }
                } while (!isValidInput || filterChoiceMainDish < 1 || filterChoiceMainDish > 3);
                
                switch (filterChoiceMainDish)
                {
                    case 1:
                        Console.Clear();
                        PROTEIN desiredProtein = ShowProteinTypes();
                        List<MainDish> filteredByProtein = _mainDishes.Where(x => x.ProteinType == desiredProtein).ToList();
                        ShowOptions(filteredByProtein);
                        
                        break;
                    case 2:
                        Console.Clear();
                        CUISINE desiredCuisine = ShowCuisineTypes();
                        List<MainDish> filteredByCuisine = _mainDishes.Where(x => x.CuisineType == desiredCuisine).ToList();
                        ShowOptions(filteredByCuisine);
                        
                        break;
                    case 3:
                        ShowOptions(_mainDishes);
                        break;
                }
                break;
            case 2:
                int filterChoiceDessert;
                do
                {
                    Console.WriteLine("\n\n Choose the option that satisfies you the most:");
                    Console.WriteLine("1. Filter by GLUTEN\n2. Filter by BAKED\n3. Show ALL");
                    
                    isValidInput = int.TryParse(Console.ReadLine(), out filterChoiceDessert);
                    if (!isValidInput || filterChoiceDessert < 1 || filterChoiceDessert > 3)
                    {
                        Console.WriteLine("Invalid input. Please select a valid option.:");
                        Console.ReadKey();
                    }
                } while (!isValidInput || filterChoiceDessert < 1 || filterChoiceDessert > 3);
                
                switch (filterChoiceDessert)
                {
                    case 1:
                        int glutenChoice;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Do you want it GLUTEN FREE?\n1. YES\n2. NO");
                            
                            isValidInput = int.TryParse(Console.ReadLine(), out glutenChoice);
                            if (!isValidInput || glutenChoice < 1 || glutenChoice > 2)
                            {
                                Console.WriteLine("Invalid input. Please select a valid option.:");
                                Console.ReadKey();
                            }
                        } while (!isValidInput || glutenChoice < 1 || glutenChoice > 2);
                        
                        switch (glutenChoice)
                        {
                            case 1:
                                List<Dessert> filteredByGlutenFree = _desserts.Where(d => d.IsGlutenFree).ToList();
                                ShowOptions(filteredByGlutenFree);
                                
                                break;
                            case 2:
                                List<Dessert> filteredByGluten = _desserts.Where(d => d.IsGlutenFree == false).ToList();
                                ShowOptions(filteredByGluten);
                                break;
                        }
                        
                        break;
                    case 2:
                        int bakedChoice;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Do you want it baked?\n1. YES\n2. NO");
                            
                            isValidInput = int.TryParse(Console.ReadLine(), out bakedChoice);
                            if (!isValidInput || bakedChoice < 1 || bakedChoice > 2)
                            {
                                Console.WriteLine("Invalid input. Please select a valid option.:");
                                Console.ReadKey();
                            }
                        } while (!isValidInput || bakedChoice < 1 || bakedChoice > 2);
                        
                        switch (bakedChoice)
                        {
                            case 1:
                                List<Dessert> filterByBaked = _desserts.Where(d => d.IsBaked).ToList();
                                ShowOptions(filterByBaked);
                                
                                break;
                            case 2:
                                List<Dessert> filterByNotBaked = _desserts.Where(d => d.IsBaked == false).ToList();
                                ShowOptions(filterByNotBaked);
                                break;
                        }
                        
                        break;
                    case 3:
                        ShowOptions(_desserts);
                        break;
                }
                break;
            case 3:
                int filterChoiceDrink;
                do
                {
                    Console.WriteLine("\n\n Choose the option that satisfies you the most:");
                    Console.WriteLine("1. Filter by ALCOHOL\n2. Filter by TEMPERATURE\n3. Show ALL");
                    
                    isValidInput = int.TryParse(Console.ReadLine(), out filterChoiceDrink);
                    if (!isValidInput || filterChoiceDrink < 1 || filterChoiceDrink > 3)
                    {
                        Console.WriteLine("Invalid input. Please select a valid option.:");
                        Console.ReadKey();
                    }
                } while (!isValidInput || filterChoiceDrink < 1 || filterChoiceDrink > 3);
                
                switch (filterChoiceDrink)
                {
                    case 1:
                        int alcoholChoice;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("Do you want it WITH ALCOHOL?\n1. YES\n2. NO");
                            
                            isValidInput = int.TryParse(Console.ReadLine(), out alcoholChoice);
                            if (!isValidInput || alcoholChoice < 1 || alcoholChoice > 2)
                            {
                                Console.WriteLine("Invalid input. Please select a valid option.:");
                                Console.ReadKey();
                            }
                        } while (!isValidInput || alcoholChoice < 1 || alcoholChoice > 2);
                        
                        switch (alcoholChoice)
                        {
                            case 1:
                                List<Drink> filteredByWithAlcohol = _drinks.Where(d => d.IsAlcoholic).ToList();
                                ShowOptions(filteredByWithAlcohol);
                                break;
                            case 2:
                                List<Drink> filteredByNoAlcohol = _drinks.Where(d => d.IsAlcoholic == false).ToList();
                                ShowOptions(filteredByNoAlcohol);
                                break;
                        }
                        
                        break;
                    case 2:
                        Console.Clear();
                        TEMPERATURE temperature = ShowTemperatureTypes();
                        List<Drink> filteredByTemperature = _drinks.Where(d => d.Temperature == temperature).ToList();
                        ShowOptions(filteredByTemperature);
                        
                        break;
                    case 3:
                        ShowOptions(_drinks);
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
            ShowMainMenu();
        }
    }
    private static void ShowRecipe<T>(T recipe) where T : IOptionItem
    {
        recipe.DisplayDetails();
        Option.AddOption(1, "Return");
        int chosenOption = Option.ChooseOption("Type the wanted option: ");
        if (chosenOption == 1)
        {
            ShowMainMenu();
        }
    }
    
    private static string ReadLineNonNullable()
    {
        while (true)
        {
            string? input = Console.ReadLine();
        
            if (!string.IsNullOrWhiteSpace(input))
            {
                return input; 
            }
        
            Console.WriteLine("Invalid input. Please select a valid input.");
        }
    }
    
    private static PROTEIN ShowProteinTypes()
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
    
    private static CUISINE ShowCuisineTypes()
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
    
    private static TEMPERATURE ShowTemperatureTypes()
    {
        int choice;
        bool isValidInput;
        TEMPERATURE selectedTemperature = TEMPERATURE.COLD;

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