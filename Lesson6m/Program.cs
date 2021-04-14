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

            Task4();
        }

        private static void Task4()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"four",4 },
                {"two",2 },
                { "one",1 },
                {"three",3 },
            };
            //var d = dict.OrderBy(delegate(KeyValuePair<string,int> pair) { return pair.Value; });
            var d = dict.OrderBy((pair) => pair.Value);
            foreach (var pair in d)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
        }
    }
}