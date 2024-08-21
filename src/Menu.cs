using System.Diagnostics;

namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
/// restaurante.
/// </summary>




public class Menu
{
    private ArrayList dishes = new ArrayList();

    public void AddDish(Dish Newdish)
    {
        dishes.Add(Newdish);
    }

    public void RemoveDish(Dish deleteableDish)
    {
        dishes.Remove(deleteableDish);
    }

    public Dish GetDishByName(string name)
    {
        foreach (var platos in dishes)
        {
            if (((Dish)platos).Name == name)
            {
                return (Dish)platos;
            }
        }

        return null;
    }
    
    public ArrayList GetDishes()
    {
        return dishes;
    }
}
    