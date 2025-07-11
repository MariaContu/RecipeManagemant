namespace RecipesManagement;

public class Ingredient
{
    public double Quantity { get; set; }
    public string Name { get; set; }
    public string Unit { get; set; }
    public int RecipeId { get; set; }

    public Ingredient(double quantity, string name, string unit)
    {
        Quantity = quantity;
        Name = name;
        Unit = unit;
        RecipeId = 0;
    }
g
    public override string ToString()
    {
        return $"{Quantity} {Unit} de {Name} ";
    }
}