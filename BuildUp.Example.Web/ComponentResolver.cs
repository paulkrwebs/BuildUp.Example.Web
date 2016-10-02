namespace BuildUp.Example.Web
{
    using Microsoft.Practices.Unity;
    using System;
    using System.Collections.Generic;

    public class ComponentResolver : IComponentResolver
    {
        private readonly IUnityContainer _container;

        public ComponentResolver(IUnityContainer container)
        {
            _container = container;
        }

        public IEnumerable<TComponent> ResolverAll<TComponent>() where TComponent : IComponent
        {
            return _container.ResolveAll<TComponent>();
        }
    }
}