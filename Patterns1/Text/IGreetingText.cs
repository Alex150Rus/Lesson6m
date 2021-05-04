using System.Text;

namespace Patterns1.Text
{
    internal interface IGreetingText : IText
    {
        StringBuilder UserGreeting
        {
            get;
        }
    }
}