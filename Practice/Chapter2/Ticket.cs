﻿using System;
using System.Collections;
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

    [Serializable]
    [Promotable(10.0d)]
    class Ticket : IComparable<Ticket>, IEnumerable<Ticket>
    {
        public decimal Price { get; private set; }
        public TicketClass Class { get; private set; }
        public DateTime ValidityDate { get; private set; }
        public Ticket(decimal price, TicketClass ticketClass)
        {
            Price = price;
            Class = ticketClass;
            ValidityDate = DateTime.Now.AddDays(7);
        }

        public int CompareTo(Ticket other)
        {
            if(ValidityDate < DateTime.Now)
            {
                return -1;
            }
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

        public IEnumerator<Ticket> GetEnumerator()
        {
            yield return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            yield return this;
        }

        public override string ToString()
        {
            string toString = $"Price: {Price}, Ticket class: {Class}, Validity date: {ValidityDate}";

            return toString;
        }
    }
}
