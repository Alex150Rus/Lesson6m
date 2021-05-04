using System.Text;

namespace Patterns1.Text.Rus
{
    internal sealed class SayHelloRusText : IGreetingText
    {
        private StringBuilder _userGreeting;
        public StringBuilder UserGreeting => _userGreeting;

        public SayHelloRusText()
        {
            _userGreeting = new StringBuilder(
                "Здравствуйте вас приветствует математическая программа\nпажалуйста введите число.");
        }
    }
}