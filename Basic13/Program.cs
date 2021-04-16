using System;

namespace Basic13
{
    class Program
    {
                // 4. Iterating through an Array
        public static void LoopArray(int[] numbers)
            {
                for(int i=0; i<=100; i++)
                {
                    Console.WriteLine(i);
                }
            }
            public static void PrintNumbers()
{
    // Print all of the integers from 1 to 255.
            for(int i=1; i<= 255; i++)
            {
                Console.WriteLine(i);
            };
}
public static void PrintOdds()
{
    // Print all of the odd integers from 1 to 255.
            for(int i=1; i<= 255; i+=2)
            {
                Console.WriteLine(i);
            };
}
public static void PrintSum()
{
    // Print all of the numbers from 0 to 255, 
    // but this time, also print the sum as you go. 
    // For example, your output should be something like this:
    
    // New number: 0 Sum: 0
    // New number: 1 Sum: 1
    // New Number: 2 Sum: 3

                    int sum =0;
                    for(int i=0; i<=255; i++)
                    {
                        sum+=i;
                        Console.WriteLine(i);
                        Console.WriteLine(sum);
                    };
}
    public static int FindMax(int[] numbers)
{
    // Write a function that takes an integer array and prints and returns the maximum value in the array. 
    // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
    // or even a mix of positive numbers, negative numbers and zero.
    int max=numbers[0];
    for(int i=1; i<numbers.Length; i++){
        if(numbers[i]>max){
            max=numbers[i];
        }
    }
        Console.WriteLine(max);
        return max;
}
public static void GetAverage(int[] numbers)
{
    int sum=numbers[0];
    int avg=0;
    for(int i=1; i<numbers.Length; i++){
        sum+=numbers[i];
        avg=sum/numbers.Length;
    }
    Console.WriteLine(avg);
    // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
    // For example, with an array [2, 10, 3], your program should write 5 to the console.
}
public static void OddArray()
{
    for(int i=1; i<=255; i+=2){
        Console.WriteLine(i);
    }
    // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
    // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
}
public static int GreaterThanY(int[] numbers, int y)
{
    int Count=0;
    for(int i=0; i<numbers.Length; i++){
        if(numbers[i]>y){
            Count++;
        }
    }
        Console.WriteLine(Count);
        return  Count;

    // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
    // That are greater than the "y" value. 
    // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
    // (since there are two values in the array that are greater than 3).
}
public static void SquareArrayValues(int[] numbers)
{
    for(int i=0; i<numbers.Length; i++){
        numbers[i]=(numbers[i]*numbers[i]);
        Console.WriteLine(numbers[i]);
    }
    // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
    // For example, [1,5,10,-10] should become [1,25,100,100]
}


        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // int[] array ={-3, -5, -7};
            // FindMax(array);
            // int[] arr ={1,2,3,4,5};
            // GetAverage(arr);
            // OddArray();
            // int[] array={1, 3, 5, 7};
            // int y =3;
            // GreaterThanY(array,y);
                int[] array ={1,5,10,-10};
                SquareArrayValues(array);
        }
    }
}