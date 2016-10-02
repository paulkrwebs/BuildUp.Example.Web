namespace BuildUp.Example.Web
{
    using BuildUp.Example.Web.ViewModels.Pages;
    using Components;

    using Example.ContentModels;
    using Example.ContentModels.Pages;
    using Microsoft.Practices.Unity;

    public static class UnityContainerExtensions
    {
        public static FluentHanderRegistration<TToCreate, TFrom> RegisterForPage<TToCreate, TFrom>(this IUnityContainer container)
            where TToCreate : PageViewModel, new()
            where TFrom : ContentPage
        {
            return
                container.RegisterHandler<TToCreate, TFrom, MetaDataComponent<TToCreate, TFrom>>("MetaDataComponent")
                .AndRegister<HeaderComponent<TToCreate, TFrom>>("HeaderComponent")
                .AndRegister<FooterComponent<TToCreate, TFrom>>("FooterComponent");
        }

        public static FluentHanderRegistration<TToCreate, TFrom> RegisterForPage<TToCreate, TFrom, THandler>(this IUnityContainer container, string handlerName)
            where TToCreate : PageViewModel, new()
            where TFrom : ContentPage
            where THandler : IComponent<ComponentArgs<TToCreate, TFrom>>
        {
            return
                container.RegisterForPage<TToCreate, TFrom>()
                         .AndRegister<THandler>(handlerName);
        }

        public static FluentHanderRegistration<TToCreate> RegisterHandler<TToCreate, THandler>(this IUnityContainer container, string handlerName)
            where THandler : IComponent<ComponentArgs<TToCreate>>
        {
            var accumulator = new FluentHanderRegistration<TToCreate>(container);

            return accumulator.Register<THandler>(handlerName);
        }

        public static FluentHanderRegistration<TToCreate, TFrom> RegisterHandler<TToCreate, TFrom, THandler>(this IUnityContainer container, string handlerName)
            where THandler : IComponent<ComponentArgs<TToCreate, TFrom>>
        {
            var accumulator = new FluentHanderRegistration<TToCreate, TFrom>(container);

            return accumulator.Register<THandler>(handlerName);
        }
    }
}