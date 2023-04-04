
using ConsoleDependencyInjection;

//MyServiceCollection serviceCollection = new MyServiceCollection();
//serviceCollection.Register(typeof(IInternalWork), typeof(MyInternalWork));
//serviceCollection.Register(typeof(IGreetingService), typeof(HelloWorldGreetingService));
//serviceCollection.Register(typeof(GreetingApp), typeof(GreetingApp));

//var srvice = serviceCollection.Resolve<GreetingApp>();
//srvice.Run();
using Microsoft.Extensions.DependencyInjection;


var serviceProvider = new ServiceCollection()

    .AddSingleton<IInternalWork, MyInternalWork>()
    .AddSingleton<IGreetingService, HelloWorldGreetingService>()
    .AddSingleton<GreetingApp>()
    .BuildServiceProvider();


var srvice = serviceProvider.GetService<GreetingApp>();
srvice.Run();
