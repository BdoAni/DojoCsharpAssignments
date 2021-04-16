using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Food newFood = new Food("Pizza", 195, false, true);
            Console.WriteLine($"{newFood.Name} (Food).  Calories: {newFood.Calories}.  Spicy?: {newFood.IsSpicy}, Sweet?: {newFood.IsSweet}");
            Buffet newBuffet = new Buffet();
            Console.WriteLine(newBuffet.Serve().Name);
            Ninja newNinja = new Ninja();
            while (!newNinja.IsFull())
            {
                newNinja.Eat(newBuffet.Serve());
            }
        }
    }
}
