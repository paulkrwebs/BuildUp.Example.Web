namespace BuildUp.Example.Web.UI.App_Start
{
    using BuildUp.Example.Web;
    using ComponentRegistration;
    using Components.Pages;
    using Example.ContentModels.Pages;
    using Microsoft.Practices.Unity;
    using Requests.Pages;
    using System;
    using ViewModels.Pages;

    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container

        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }

        #endregion Unity Container

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // TODO: Register your types here
            // container.RegisterType<IProductRepository, ProductRepository>();

            container.RegisterType<IComponentResolver, ComponentResolver>(new InjectionConstructor(container));
            container.RegisterType<IComponentPipeline, ComponentPipeline>();
            container.RegisterType<IPropertyMapper, PropertyMapper>();
            container.RegisterType<IBuilder, Builder>();

            ContainerRegistrations.RegisterComponents(container);
        }
    }
}