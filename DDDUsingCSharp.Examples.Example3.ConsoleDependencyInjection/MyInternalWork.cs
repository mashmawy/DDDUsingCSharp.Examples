namespace DDDUsingCSharp.Examples.Example3.ConsoleDependencyInjection
{
    public class MyInternalWork : IInternalWork
    {
        public void DoWork()
        {
            Console.WriteLine("This Is Internal Work");
        }
    }

}
