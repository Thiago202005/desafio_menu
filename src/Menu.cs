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

    public string GetDishByName(string name)
    {
        if (dishes.Contains(name))
        {
            return ($"{name} esta dentro del menu");// en todas las clases en todos los casos debe haber un return, Console.Writeln no sirve
        }
        else
        {
            return null;
        }

    }
}
    