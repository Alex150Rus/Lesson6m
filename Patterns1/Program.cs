using System;
using Patterns1.Calculation;
using Patterns1.Display;
using Patterns1.Repository;
using Patterns1.Text.Rus;

namespace Patterns1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sayHelloText = new SayHelloRusText();
            var sayHelloViaConsole = new SayHelloViaConsole(sayHelloText);
            sayHelloViaConsole.SayHelloToUser();

            var inputRepository = new InputRepository();
            
            try
            { 
                inputRepository.UserInput = new TakeConsoleUserInput().TakeUserInputViaConsole();
            }
            catch (ApplicationException e)
            {
                if (e.Message == "q") return;
            }
           
            int M = inputRepository.UserInput;
            int c2 = 0;
            int c3 = 0;
            for (int i = 1; i <= M; i++)
            {
                c2 = c2 + i;
                if (i%2 == 0)
                {
                    c3 = i;
                }
            }
            Console.WriteLine("Факториал равет " + new Factorial().CalculateFactorial(inputRepository.UserInput)); 
            Console.WriteLine("Сума от 1 до N равна " + c2);
            
            Console.WriteLine("максимальное четное число меньше N равно" + c3);
            Console.ReadLine();
        }
    }
}