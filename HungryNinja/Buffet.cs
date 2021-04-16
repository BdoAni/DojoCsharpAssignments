using System;
using System.Collections.Generic;

namespace HungryNinja
{
public  class Buffet
    {
        public List<Food> Menu;
    //constructor
    public Buffet()
    {
        Menu = new List<Food>()
        {
            new Food("Beef", 900, true, false),
            new Food("Broccoli", 100, true, false),
            new Food("Cheese", 970, true, false),
            new Food("Rice", 1200, true, false),
            new Food("Herring", 1500, true, false),
            new Food("Chocolate", 1000, false, false)
        };
    }
    public Food Serve()
        {
            Random r = new Random();
            // Start at 0 on this point to count
            return Menu[r.Next(Menu.Count)];
        }
    }
}
