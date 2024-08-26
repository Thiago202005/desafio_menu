namespace Ucu.Poo.Restaurant;

using System.Collections;

public class Order
{
    private ArrayList order = new ArrayList();
    
    public void AddToOrder(Dish plato)
    {
        order.Add(plato);
    }
    public ArrayList Orders
    {
        get
        {
            return order;
        }
    }
    
    public double GetTotal()
    {
        double total = 0;
        foreach (var platos in order)
        {
            total += ((Dish)platos).Price;
        }
        return total;
    }
}