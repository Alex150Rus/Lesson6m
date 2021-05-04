using System;
using Patterns1.Display;
using Patterns1.Text.Rus;

namespace Patterns1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sayHelloRusText = new SayHelloRusText();
            var sayHelloViaConsole = new SayHelloViaConsole(sayHelloRusText);
            sayHelloViaConsole.SayHelloToUser();

            String S = Console.ReadLine();

            if (S == "q"){
                return;
            }
            int M = Int32.Parse(S);
            int c1 = 1; int c2 = 0;
            int c3 = 0;
            for (int i = 1; i <= M; i++)
            {
                c1 = c1*i;
                c2 = c2 + i;
                if (i%2 == 0)
                {
                    c3 = i;
                }
            }
            Console.WriteLine("Факториал равет " + c1); Console.WriteLine("Сума от 1 до N равна " + c2);

            Console.WriteLine("максимальное четное число меньше N равно" + c3);
            Console.ReadLine();
        }
    }
}