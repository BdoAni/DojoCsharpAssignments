using System;
using System.Collections.Generic;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objectives////////
            // int[] numArray;
            // numArray={0,1,2,3,4,5,6,7,8,9};
            // //     Console.WriteLine(i);
            // for(int i=0; i<=9; i++){
            //     Console.WriteLine(i);
            // }
            string[] names =new string[]{"Tim", "Martin", "Nikki", "Sara"};
            foreach(string name in names)
            {
            Console.WriteLine($"list of names are: {name}");
            }
            // ///////////////////////////////////////
            // for(int i=0; i<names.Length; i++){
            //     Console.WriteLine(names[i]);
            // }
            // Three Basic Arrays/////////
            // List<bool>  trueOrFalse = new List<bool>();
            // for(int i=1; i<=10; i++)
            // {
            //     if(i%2==0)
            //     {
            //         trueOrFalse.Add(false);
            //     }
            //     else
            //     {
            //         trueOrFalse.Add(true);
            //     }
            // }
            // for(int k=0; k<trueOrFalse.Count; k++)
            // {
            //     Console.WriteLine(trueOrFalse[k]);
            // };
            // List of Flavors///////
            List<string> iceCream = new List<string>();
                iceCream.Add("Vanilla");
                iceCream.Add("Chocolate");
                iceCream.Add("Mint Chocolate Chip");
                iceCream.Add("Chocolate Chip Cookie Dough");
                iceCream.Add("Strawberry");
                {
                Console.WriteLine(iceCream[2]);
                // Console.WriteLine($"My favorites  {iceCream.Count}!.");
                }
                iceCream.Remove("Mint Chocolate Chip");
                {
                    Console.WriteLine(iceCream.Count);
                }
                // User Info Dictionary//////
                Dictionary<string,string> namesFlavors = new Dictionary<string,string>();
                        for(int i=0; i<=3; i++)
                        {
                            namesFlavors.Add(names[i], iceCream[i]);
                        }
                        foreach (var entry in namesFlavors)
                        {
                            Console.WriteLine(entry.Key + " - " + entry.Value);
                        }
        }
    }
}
