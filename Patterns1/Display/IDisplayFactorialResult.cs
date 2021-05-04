using Patterns1.Text;

namespace Patterns1.Display
{
    internal interface IDisplayFactorialResult
    {
        void DisplayFactorialResult(int factorial, IFactorialResultText factorialResultText);
    }
}