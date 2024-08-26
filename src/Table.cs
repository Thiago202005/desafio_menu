namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private ArrayList order = new ArrayList();

    public ArrayList Order
    {
        get
        {
            return order;
        }
    }


    public bool HasOrders()
    {
        return order.Count > 0;
    }

    private int number;
    
    public int Number
    {
        get
        {
            return number;
        }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Error, el id de la mesa no puede ser negativo.");
            }
            else
            {
                number = value;
            }
        }
    }

    private bool isOccupied;
    
    public bool IsOccupied
    {
        get
        {
            return isOccupied;
        }
        
        
    }

    public Table(int number)
    {
        this.number = number;
    }
    public void Ocupy()
    {
        isOccupied = true;
    }

    public void Free()
    {
        isOccupied = false;
        order.Clear();
    }

    public void AddToOrder(Dish plato)
    {
        order.Add(plato);
    }
}