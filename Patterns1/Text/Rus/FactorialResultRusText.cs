using System.Text;

namespace Patterns1.Text.Rus
{
    internal sealed class FactorialResultRusText : IFactorialResultText
    {
        private StringBuilder _factorialResultText;
        public StringBuilder FactorialResultText => _factorialResultText;

        public FactorialResultRusText()
        {
            _factorialResultText = new StringBuilder("Факториал равен ");
        }
    }
}