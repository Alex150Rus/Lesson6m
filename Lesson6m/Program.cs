using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson6m
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World!";
            Console.WriteLine(str.GetQtyOfCharsInString('H'));
            List<int> list = new List<int>{0, 5, 7, 6, 9, 3, 0, 5, 6, 6};
            Console.WriteLine(list.GetQtyOfInteger(9));
            Console.WriteLine(5.GetQtyOfElements(list));

            int qty = list.FindAll(i => i == 6).Count;
            Console.WriteLine(qty);

            int qty2 = list.Where(i => i == 0).ToArray().Length;
            Console.WriteLine(qty2);
        }
    }
}