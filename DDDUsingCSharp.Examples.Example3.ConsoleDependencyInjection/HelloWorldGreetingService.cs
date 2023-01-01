namespace DDDUsingCSharp.Examples.Example3.ConsoleDependencyInjection
{
    public class HelloWorldGreetingService : IGreetingService
    {
        private readonly IInternalWork internalWork;

        public HelloWorldGreetingService(IInternalWork internalWork)
        {
            this.internalWork = internalWork;
        }
        public string GetGreetingMessage()
        {
            internalWork.DoWork();
            return "Hello World";
        }
    }

}
