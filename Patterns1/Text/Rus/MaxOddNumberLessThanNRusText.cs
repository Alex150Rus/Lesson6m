using System.Text;

namespace Patterns1.Text.Rus
{
    internal sealed class MaxOddNumberLessThanNRusText : IMaxOddNumberLessThanNText
    {
        private StringBuilder _maxOddNumber;
        public StringBuilder MaxOddNumberLessThanNText => _maxOddNumber;

        public MaxOddNumberLessThanNRusText()
        {
            _maxOddNumber = new StringBuilder("максимальное четное число меньше N равно ");
        }
    }
}