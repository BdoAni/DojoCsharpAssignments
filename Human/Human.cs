using System;
using System.Collections.Generic;
namespace Human
{
    class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health;
        public int Health
        {
            get { return  health; }
        }
        public Human(string input)
        {
            Name=input;
            Strength=3;
            Intelligence=3;
            Dexterity=3;
            health=100;

        }
        public Human(string input, int str, int intel, int dex, int life)
        {
            Name=input;
            Strength=str;
            Intelligence=intel;
            Dexterity=dex;
            health=life;

        }
    // add a public "getter" property to access health
    // Add a constructor that takes a value to set Name, and set the remaining fields to default values
    // Add a constructor to assign custom values to all fields
    // Build Attack method
        public int Attack(Human target)
        {
            int dmg =Strength *5;
            target.health -= dmg;
            Console.WriteLine ($"{Name} has done {dmg} damage to {target.Name}!");
            return target.health;
        }
    }
}