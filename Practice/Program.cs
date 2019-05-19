using Practice.Chapter2;
using Practice.Chapter2.TypeConversions;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "encyclopaedia";
            string str2 = "encyclopædia";

            Console.WriteLine(str1.Equals(str2, StringComparison.InvariantCulture));

            var ticket = new Ticket(18.99m, TicketClass.Business);
            Console.WriteLine("Ticket: {0:G}", ticket);
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
 