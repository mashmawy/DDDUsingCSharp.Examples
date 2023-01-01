using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDUsingCSharp.Examples.Example3.ConsoleDependencyInjection
{
    public class UserInputGreetingService : IGreetingService
    {
        public string GetGreetingMessage()
        {
            Console.WriteLine("Please Insert Greeting Message");
            return Console.ReadLine();
        }
    }
}
