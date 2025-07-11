namespace RecipesManagement;

using System;
using System.Collections.Generic;

public class Option
{
    public static List<Option> listOptions = new List<Option>();
    public int Index { get; set; }
    public string Message { get; set; }

    public Option(int index, string message)
    {
        Index = index;
        Message = message;
    }

    public static int ChooseOption(string msg)
    {
        Console.Write(msg);
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input) || !int.TryParse(input, out int option))
        {
            Console.WriteLine("Digite um número correspondente do menu numérico.");
            return ChooseOption(msg);
        }

        if (option > 0 && option <= listOptions.Count)
        {
            listOptions.Clear();
            return option;
        }
        else
        {
            Console.WriteLine("Digite um número correspondente do menu numérico.");
            return ChooseOption(msg);
        }
    }

    public static void AddOption(int index, string msg)
    {
        Option option = new Option(index, msg);
        listOptions.Add(option);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{index}. ");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(msg);
        Console.ResetColor();
    }

    public static void AddTitleOfMenu(string title)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(title);
        Console.ResetColor();
    }
}
