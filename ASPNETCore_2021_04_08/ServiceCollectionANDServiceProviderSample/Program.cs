using System;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceCollectionANDServiceProviderSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddSingleton<ClassA>();

            serviceCollection.AddSingleton<IThing, ClassB>(); //Bessere Variante


            // See https://www.stevejgordon.co.uk/aspnet-core-dependency-injection-what-is-the-iserviceprovider-and-how-is-it-built
            var serviceProvider = serviceCollection.BuildServiceProvider();


            //erhalte ClassB 
            var dependency = serviceProvider.GetRequiredService<IThing>();
        }
    }



    public interface IThing
    {
        public void DoStuff();
    }

    public class ClassA
    {
        private readonly IThing _dependency;

        public ClassA(IThing thing) => _dependency = thing;

        public void DoWork() => _dependency.DoStuff();
    }

    public class ClassB : IThing
    {
        public void DoStuff()
        {
            // Imagine implementation
        }
    }
}
