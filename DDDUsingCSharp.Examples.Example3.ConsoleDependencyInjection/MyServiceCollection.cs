using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDUsingCSharp.Examples.Example3.ConsoleDependencyInjection
{
    public class MyServiceCollection
    {
        public Dictionary<Type, Type> ServiceCollection { get; set; } = new Dictionary<Type, Type>();

        public void Register(Type contract, Type target)
        {
            ServiceCollection.Add(contract, target);
        }

        public object Resolve(Type targetType)
        {
            var ctrparamsinfos = targetType.GetConstructors().FirstOrDefault().GetParameters();
            List<object> ctrparams = new List<object>();
            foreach (var item in ctrparamsinfos)
            {
                var paramtype = ServiceCollection[item.ParameterType];
                var obj = Resolve(paramtype);
                ctrparams.Add(obj);
            }
            return Activator.CreateInstance(targetType, ctrparams.ToArray());
        }

        public T Resolve<T>() where T : class
        {
            var type = typeof(T);
            return Resolve(type) as T;
        }

    }
}
