using Practice.Chapter2;
using Practice.Chapter2.TypeConversions;
using System;
using System.Dynamic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Ticket(9.99m, TicketClass.First);
            var t2 = new Ticket(19.99m, TicketClass.Business);

            Console.WriteLine(t2.CompareTo(t1));
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
 