namespace DDDUsingCSharp.Examples.Example3.WebDependencyInjection
{
    public class SingletonService : ISingletonService
    {
        readonly string myvalue;
        public SingletonService()
        {
            myvalue = Guid.NewGuid().ToString();
        }
        public string GetValue() => myvalue;


    }
}