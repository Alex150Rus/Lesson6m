using System;
using System.Text;
using Patterns1.Text;
using Patterns1.Text.Rus;

namespace Patterns1.Display
{
    internal sealed class DisplayMaxOddNumberLessThanNTextViaConsole : IDisplayMaxOddNumberLessThanN
    {
        public void DisplayMaxOddNumberLessThanN(int oddNumber, IMaxOddNumberLessThanNText displayString)
        {
            Console.WriteLine(displayString.MaxOddNumberLessThanNText.Append(oddNumber));
        }
    }
}