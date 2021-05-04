using System.Text;

namespace Patterns1.Text.Rus
{
    internal sealed class SumFromOneToNRusText : ISumFromOneToNText
    {
        private StringBuilder _sumFromOneToNText;
        public StringBuilder SumFromOneToNText => _sumFromOneToNText;

        public SumFromOneToNRusText()
        {
            _sumFromOneToNText = new StringBuilder("Сумма от 1 до N равна ");
        }
    }
}