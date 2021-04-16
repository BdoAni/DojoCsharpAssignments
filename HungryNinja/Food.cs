using System;
using System.Collections.Generic;
namespace HungryNinja
{
    public class Food
        {
                public string Name;
                public int Calories;
                // Foods can be Spicy and/or Sweet
                public bool IsSpicy; 
                public bool IsSweet; 
                // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
                        public Food(string name, int calories, bool spicy, bool sweet)
                        {
                            Name = name;
                            Calories = calories;
                            IsSpicy = spicy;
                            IsSweet = sweet;
                        // Console.WriteLine($"{Name} (Food).  Calories: {Calories}.  Spicy?: {IsSpicy}, Sweet?: {IsSweet}");
                            // return  Food;
                        }
        }
}