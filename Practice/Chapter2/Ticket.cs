using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
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
    class Ticket : IComparable<Ticket>, IEnumerable<Ticket>, IFormattable
    {
        public decimal Price { get; private set; }
        public TicketClass Class { get; private set; }
        public DateTime ValidityDate { get; private set; }
        public CultureInfo Culture { get; set; }
        public Ticket(decimal price, TicketClass ticketClass, CultureInfo culture = null)
        {
            Price = price;
            Class = ticketClass;
            ValidityDate = DateTime.Now.AddDays(7);
            
            if(culture == null)
            {
                Culture = CultureInfo.CurrentCulture;
            }
            else
            {
                Culture = culture;
            }
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
            string toString = $"Price: {Price.ToString("C", Culture)}, Ticket class: {Class}, Validity date: {ValidityDate}";

            return toString;
        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrWhiteSpace(format))
            {
                format = "G";
            }

            switch(format)
            {
                case "P":
                    return Price.ToString();
                case "C":
                    return Class.ToString();
                case "D":
                    return ValidityDate.ToString();
                case "G":
                    return $"Class: {Class}, valid until: {ValidityDate}";
                default:
                    throw new FormatException("Format specified was invalid.");
            }
        }
    }
}
