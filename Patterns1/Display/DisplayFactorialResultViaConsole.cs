using System;
using System.Text;
using Patterns1.Text;

namespace Patterns1.Display
{
    internal sealed class DisplayFactorialResultViaConsole : IDisplayFactorialResult
    {
        public void DisplayFactorialResult(int factorial, IFactorialResultText factorialResultText)
        {
            Console.WriteLine(factorialResultText.FactorialResultText.Append(factorial));
        }
    }
}