using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDUsingCSharp.Examples.Example3.ConsoleDependencyInjection
{
    public class GreetingApp
    {
        private readonly IGreetingService greetingService;

        public GreetingApp(IGreetingService greetingService)
        {
            this.greetingService = greetingService;
        }

        public void Run()
        {
            Console.WriteLine(greetingService.GetGreetingMessage());
        }
    }
}
