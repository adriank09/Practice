using Practice.Chapter2.TypeConversions;
using System;
using System.Dynamic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //MessageDisplay m = new MessageDisplay();
            //m.Display("Hello world!");

            ////dynamic d = new MessageDisplay();
            ////d.TryDisplay("Hello world!");

            //dynamic a = new ExpandoObject();
            //a.Foo = "Bar";

            //Console.WriteLine(a.Foo);

            Foo foo = new Foo();
            foo.Display();

            Bar bar = new Bar();
            bar.Display();
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

    class MessageDisplay
    {
        public void Display(string message)
        {
            Console.WriteLine(message);
        }
    }


    class Foo
    {
        public virtual void Display()
        {
            Console.WriteLine("Displaying foo");
        }
    }

    class Bar : Foo
    {
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Displaying bar");
        }
    }
}
 