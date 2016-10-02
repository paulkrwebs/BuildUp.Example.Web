namespace BuildUp.Example.Web
{
    using BuildUp;
    using Microsoft.Practices.Unity;

    public class FluentHanderRegistration<TToCreate, TFrom>
    {
        protected readonly IUnityContainer Container;

        public FluentHanderRegistration(IUnityContainer container)
        {
            Container = container;
        }

        public IUnityContainer IocConainer()
        {
            return Container;
        }

        public FluentHanderRegistration<TToCreate, TFrom> AndRegister<THandler>(string handlerName)
            where THandler : IComponent<ComponentArgs<TToCreate, TFrom>>
        {
            return Register<THandler>(handlerName);
        }

        public FluentHanderRegistration<TToCreate, TFrom> Register<THandler>(string handlerName)
            where THandler : IComponent<ComponentArgs<TToCreate, TFrom>>
        {
            Container.RegisterType<IComponent<ComponentArgs<TToCreate, TFrom>>, THandler>(handlerName);

            return this;
        }
    }
}