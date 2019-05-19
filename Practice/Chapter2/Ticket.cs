using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Chapter2
{
    enum TicketClass
    {
        Undefined,
        Economy,
        Business,
        First
    }

    class Ticket : IComparable<Ticket>
    {
        public decimal Price { get; private set; }
        public TicketClass Class { get; private set; }

        public Ticket(decimal price, TicketClass ticketClass)
        {
            Price = price;
            Class = ticketClass;
        }

        public int CompareTo(Ticket other)
        {
            if (other.Class < this.Class)
            {
                return 1;
            }
            else if(other.Class == this.Class)
            {
                return Price.CompareTo(other.Price);
            }
            else
            {
                return -1;
            }
        }
    }
}
