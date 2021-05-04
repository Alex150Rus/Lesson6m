using System.Text;

namespace Patterns1.Text
{
    internal interface ISumFromOneToNText : IText
    {
        StringBuilder SumFromOneToNText
        {
            get;
        }
    }
}