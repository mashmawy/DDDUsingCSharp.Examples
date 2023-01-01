namespace DDDUsingCSharp.Examples.Example3.WebDependencyInjection
{
    public class TransientService : ITransientService
    {
        readonly string myvalue;
        public TransientService()
        {
            myvalue = Guid.NewGuid().ToString();
        }
        public string GetValue() => myvalue;

    }
}