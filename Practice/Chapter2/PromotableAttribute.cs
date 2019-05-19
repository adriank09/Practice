using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Chapter2
{
    /// <summary>
    /// Defines an attribute where promotion is allowed.
    /// </summary>
    class PromotableAttribute : Attribute
    {
        public double PromotionPercentage { get; private set; }
        public string PromotionMessage { get; private set; }

        public PromotableAttribute(double percent)
        {
            PromotionPercentage = percent;
        }

        public PromotableAttribute(double percent, string message)
        {
            PromotionPercentage = percent;
            PromotionMessage = message;
        }
    }
}
