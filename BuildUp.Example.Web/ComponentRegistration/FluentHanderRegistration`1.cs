namespace BuildUp.Example.Web
{
    using BuildUp;
    using Microsoft.Practices.Unity;

    public class FluentHanderRegistration<TToCreate>
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

        public FluentHanderRegistration<TToCreate> AndRegister<THandler>(string handlerName)
            where THandler : IComponent<ComponentArgs<TToCreate>>
        {
            return Register<THandler>(handlerName);
        }

        public FluentHanderRegistration<TToCreate> Register<THandler>(string handlerName)
            where THandler : IComponent<ComponentArgs<TToCreate>>
        {
            Container.RegisterType<IComponent<ComponentArgs<TToCreate>>, THandler>(handlerName);

            return this;
        }
    }
}