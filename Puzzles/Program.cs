using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x=RandomArray();
            //  Console.WriteLine(x.Length);
            Console.WriteLine($"TossCoin() returned{TossCoin()}");
            double headsRatio =TossMultipleCoins(5);
            Console.WriteLine(headsRatio);
            // Names();
            List<string> longerNames=Names();
            Console.WriteLine(String.Join(",", longerNames));
        }
        // We will create methods at first.
        //   Create a function called RandomArray() that returns an integer array
// Place 10 random integer values between 5-25 into the array
// Print the min and max values of the array
// Print the sum of all the values
        // 
        static int[] RandomArray()
        {
            Random r = new Random();
            int[] randNums=new int[10];
            int min = int.MaxValue;
            int max = int.MinValue;
            {
                for(int i=0; i<10; i++)
                {
                    int rand =r.Next(5,26);
                    if(rand<min)
                    {
                        min = rand;
                    }
                    if(rand<max){
                        max = rand;
                    }
                    randNums[i]=rand;
                }
            }
            Console.WriteLine($"Min: {min}, Max:{max}");
            return randNums;
        }
        // *Coin Flip
// Create a function called TossCoin() that returns a string

// Have the function print "Tossing a Coin!"
// Randomize a coin toss with a result signaling either side of the coin 
// Have the function print either "Heads" or "Tails"
// Finally, return the result
// Create another function called TossMultipleCoins(int num) that returns a Double

// Have the function call the tossCoin function multiple times based on num value
// Have the function return a Double that reflects the ratio of head toss to total toss*\\\\\

        static string TossCoin()
            {
                    Random r = new Random();
                    int rand =r.Next(0,2);
                    string result ="Heads";
                Console.WriteLine("Tossing a Coin!");
                if(rand == 0)
                {
                    result ="Tails";
                    // Console.WriteLine(result);
                }
                // else{
                //     result ="Heads"
                    Console.WriteLine(result);
                    return result;
                // }
            }

            static double TossMultipleCoins(int num) 
            {
                int headsCount = 0;
                for (int i = 0; i < num; i++)
                    {
                        string result =TossCoin();
                        if(result == "Heads")
                        {
                        headsCount++;
                        }
                    }
                    return headsCount/num;
            }
            // Build a function Names that returns a list of strings.  In this function:
            // Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
            // Shuffle the list and print the values in the new order
            // Return a list that only includes names longer than 5 characters

            static List<string> Names()
            {
                List<string> names =new List<string>
                {
                    "Todd", "Tiffany", "Charlie", "Geneva", "Sydney"
                };
                List<string> longerNames =new List<string>();
                for (int i = 0; i < names.Count; i++)
                            {
                                Random r =new Random();
                                int rand =r.Next(0, names.Count);
                                string temp =names[i];
                                names[i]=names[rand];
                                names[rand]=temp;
                                // if(names[i].Length>5)
                                // {
                                //     longerNames.Add(names[i]);
                                // }
                            }
                            foreach (string name in names)
                            {
                                if(name.Length>5)
                                {
                                    longerNames.Add(name);
                                }
                            }
                            // Console.WriteLine(String.Join(',', names));
                            return longerNames;
                    }
            }
    }

