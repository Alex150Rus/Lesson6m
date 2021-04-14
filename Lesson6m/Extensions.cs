using System;
using System.Collections.Generic;

namespace Lesson6m
{
    internal static class Extensions
    {
        internal static int GetQtyOfCharsInString(this string self, char value)
        {
            if (!self.Contains(value))
                return 0;
            
            int qty = 0;
            foreach (var item in self)
                if (item == value)
                    qty++;
            return qty;
        }

        internal static int GetQtyOfInteger(this List<int> self, int value)
        {
            if (!self.Contains(value))
                return 0;
            
            int qty = 0;
            foreach (var item in self)
                if (item == value)
                    qty++;
            return qty;
        } 
        
        internal static int GetQtyOfElements<T>(this T self, ICollection<T> value)
        {
            int qty = 0;
            foreach (var item in value)
                if (item.Equals(self))
                    qty++;
            return qty;
        } 
    }
}