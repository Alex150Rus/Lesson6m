using System;
using Patterns1.Text;

namespace Patterns1.Display
{
    internal sealed class DisplaySumFromOneToNViaConsole : IDisplaySumFromOneToN
    {
        public void DisplaySumFromOneToN(int sum, ISumFromOneToNText displayString)
        {
            Console.WriteLine(displayString.SumFromOneToNText.Append(sum));
        }
    }
}