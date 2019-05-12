using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Chapter2.TypeConversions
{
    class Miles
    {
        public double Distance { get; }

        // conversion operator for implicit conversion to kilometers
        public static implicit operator Kilometers(Miles t)
        {
            Console.WriteLine("Implicit conversion from miles to kilometers");
            return new Kilometers(t.Distance * 1.6);
        }

        public static explicit operator int(Miles t)
        {
            Console.WriteLine("Explicit conversion from miles to int");
            return (int)(t.Distance + 0.5);
        }

        public Miles(double miles)
        {
            Distance = miles;
        }
    }
}
