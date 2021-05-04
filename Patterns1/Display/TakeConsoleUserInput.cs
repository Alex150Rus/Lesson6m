using System;

namespace Patterns1.Display
{
    internal sealed class TakeConsoleUserInput : ITakeUserInputViaConsole
    {
        public int TakeUserInputViaConsole()
        {
            string input = Console.ReadLine();
            if (input == "q")
            {
                throw new ApplicationException("q");
            }
            return  int.TryParse(input, out int userInput) ? userInput : 0;
        }
    }
}