using Practice.Chapter2.TypeConversions;
using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void ImplicitExplicitDemo()
        {
            Miles m = new Miles(100.5);

            // implicitly convert miles to km
            Kilometers k = m;
            Console.WriteLine("Kilometers: {0}", k.Distance);

            // explicitly convert miles to int
            int milesInInt = (int)m;
            Console.WriteLine("Miles in int: {0}", milesInInt);
        }
    }
}
 