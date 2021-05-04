using System.Text;

namespace Patterns1.Text
{
    internal interface IFactorialResultText : IText
    {
        StringBuilder FactorialResultText
        {
            get;
        }
    }
}