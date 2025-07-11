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
            Console.WriteLine("╔══════════════════╗");
            Console.WriteLine("║   RICA PANCITA   ║");
            Console.WriteLine("╚══════════════════╝");
            Console.WriteLine("1. Categorias");
            Console.WriteLine("2. Soborô");
            Console.WriteLine("3. Sair");
        
            isValidInput = int.TryParse(Console.ReadLine(), out choice);
            if (!isValidInput || choice < 1 || choice > 3)
            {
                Console.WriteLine("Entrada inválida! Digite a opção desejada:");
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
                break;
            case 3:
                Console.Clear();
                Environment.Exit(0);
                break;
        }
    }
}