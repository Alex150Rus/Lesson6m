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
            
            Dictionary<char, int> dictionary = new Dictionary<char, int>(self.Length);
            foreach (char item in self)
            {
                if (item.Equals(value) && dictionary.ContainsKey(value))
                    dictionary[value]+= 1;
                else if (item.Equals(value) && !dictionary.ContainsKey(value))
                    dictionary[value] = 1;
            }
            
            return dictionary[value];
        }
    }
}