using System.Diagnostics;
using System;
    
namespace Ucu.Poo.Restaurant;

using System.Collections;

public class Program
{
    static void Main()
    {
        Dish d1 = new Dish("milanesa", 300, false);
        Menu m1 = new Menu();
    
        m1.AddDish(d1);
        Dish resultado = m1.GetDishByName("milanesa");
        Console.WriteLine(resultado.Name); 
        
        d1.Name = "milanesa napolitana";
        resultado = m1.GetDishByName("milanesa");
        Console.WriteLine(resultado.Name); 
    }
    

}