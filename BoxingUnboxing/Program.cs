using System;
using System.Collections.Generic;
namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
        List <object> BoxingUnboxing = new List<object>();
        BoxingUnboxing.Add(7);
        BoxingUnboxing.Add(28);
        BoxingUnboxing.Add(-1);
        bool b = true;
        BoxingUnboxing.Add(b.ToString());
        BoxingUnboxing.Add("chair");
        foreach (var i in BoxingUnboxing)
        {
            Console.WriteLine(i);
        };
        int sum=0;
        for( int i=0; i<=BoxingUnboxing.Count-1; i++ )
            {
                if(BoxingUnboxing[i] is int)
                {
                    sum+=(int)BoxingUnboxing[i];
                }
            }
                Console.WriteLine(sum);
        }
    }
}
