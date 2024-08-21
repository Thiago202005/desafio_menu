namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    private string name;
    public string Name
    {
        get { return name; } set { name = value; }
    }
    
    private float price;
    public float Price
    {
        get { return price; } set { price = value; }
    }
    
    private bool isVegetarian;
    public bool IsVegetarian
    {
        get { return isVegetarian;} set { isVegetarian = value; }
    }
    private Dish(string name, float price, bool isVegetarian)
    {
        this.name = name;
        this.price = price;
        this.isVegetarian = isVegetarian;
    }
}