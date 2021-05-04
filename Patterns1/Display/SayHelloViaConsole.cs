using System;
using System.Text;
using Patterns1.Text;

namespace Patterns1.Display
{
    internal sealed class SayHelloViaConsole : ISayHelloToUser
    {
        private IGreetingText _sayHelloText;

        public SayHelloViaConsole(IGreetingText sayHelloText)
        {
            _sayHelloText = sayHelloText;
        }
        
        public void SayHelloToUser()
        {
            Console.WriteLine(_sayHelloText.UserGreeting);
        }
    }
}