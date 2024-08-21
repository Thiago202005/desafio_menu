using System.Collections;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    private ArrayList assignedTables = new ArrayList();
    private String name;
    
    public String Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    
    public Waiter(string name)
    {
        this.name = name;
    }

    public ArrayList AssignTable(Table mesa)
    {
        assignedTables.Add(mesa);
        return assignedTables;
    }

    public void  TakeOrder(Table table, Dish plato)
    {
        if (assignedTables.Contains(table))
        {
            table.AddToOrder(plato);
        }
    }
    
}