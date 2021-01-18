using System;
using Autofac;
using Poke.Client.ViewModels;

namespace Poke.Client.Bootstrap
{
    public class AppContainer
    {
        private static IContainer container;

        public AppContainer()
        {
            // services
            var builder = new ContainerBuilder();
            //builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();

            // view models
            builder.RegisterType<PokeDashViewModel>().SingleInstance();

            container = builder.Build();
        }

        public T Resolve<T>() => container.Resolve<T>();

        public object Resolve(Type type) => container.Resolve(type);
    }
}
