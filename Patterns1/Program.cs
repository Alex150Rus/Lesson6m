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
            
            new DisplayFactorialResultViaConsole().DisplayFactorialResult(
                    new Factorial().CalculateFactorial(inputRepository.UserInput),
                    new FactorialResultRusText());
            
            Console.WriteLine("Сума от 1 до N равна " + new SumFromOneToN().calculateSumFromOneToN(inputRepository.UserInput));
            
            Console.WriteLine("максимальное четное число меньше N равно" + new CalculateMaxOddNumberLessThanN().CalcMaxOddNumberLessThanN(inputRepository.UserInput));
            Console.ReadLine();
        }
    }
}