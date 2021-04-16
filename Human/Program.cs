using System;
using System.Collections.Generic;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human firstHuman =new Human("Alex");
            Console.WriteLine($"{firstHuman.Name} has {firstHuman.Strength} strength, {firstHuman.Intelligence} intelligence, {firstHuman.Dexterity} dexterity,{firstHuman.Health} health!");


            Human secondHuman =new Human("Steven", 3,10,6,69);
            Console.WriteLine($"{secondHuman.Name} has {secondHuman.Strength} strength, {secondHuman.Intelligence} intelligence, {secondHuman.Dexterity} dexterity,{secondHuman.Health} health!");
            firstHuman.Attack(secondHuman);
            // secondHuman.Attack(firstHuman);
            Console.WriteLine(secondHuman.Health);
            // Console.WriteLine(firstHuman.Health);
        }
    }
}
