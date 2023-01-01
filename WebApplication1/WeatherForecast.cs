namespace DDDUsingCSharp.Examples.Example3.WebDependencyInjection
{
    public class ScopedService : IScopedService
    {
        readonly string myvalue;
        public ScopedService()
        {
            myvalue = Guid.NewGuid().ToString();
        }
        public string GetValue() => myvalue;

    }
}