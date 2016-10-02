namespace BuildUp.Example.Web.ComponentRegistration
{
    using AutoMapper;
    using BuildUp;
    using BuildUp.Example.ContentModels.Pages;
    using BuildUp.Example.Web.Components;
    using BuildUp.Example.Web.Components.Pages;
    using BuildUp.Example.Web.ContentModels;
    using BuildUp.Example.Web.ViewModels;
    using BuildUp.Example.Web.ViewModels.Pages;
    using Example.ContentModels.Blocks;
    using Microsoft.Practices.Unity;
    using System.Collections.Generic;
    using ViewModels.Blocks;

    public class ContainerRegistrations : Profile
    {
        public ContainerRegistrations()
        {
            // Setup automapper registrations
            CreateMap<HomepageContent, HomepageViewModel>().MaxDepth(1)
                .ForMember(x => x.MetaData, c => c.Ignore())
                .ForMember(x => x.FeaturedItems, c => c.Ignore()); // We are going to deal with the mapping so ignore this property

            CreateMap<MetaDataContent, MetaDataViewModel>().MaxDepth(1);
            CreateMap<FeaturedItemContent, FeaturedItemViewModel>().MaxDepth(1);
        }

        public static void RegisterComponents(IUnityContainer container)
        {
            RegisterPages(container);
            RegisterBlocks(container);
            RegisterSubComponents(container);
        }

        private static void RegisterPages(IUnityContainer container)
        {
            container.RegisterForPage<HomepageViewModel, HomepageContent, HomepageComponent>("HomepageComponent");
        }

        private static void RegisterBlocks(IUnityContainer container)
        {
            container.RegisterHandler<FeaturedItemViewModel, FeaturedItemContent,
                           PropertyMapperComponent<FeaturedItemViewModel, FeaturedItemContent>>("PropertyMapperComponent<FeaturedItemViewModel, FeaturedItemContent>");
        }

        private static void RegisterSubComponents(IUnityContainer container)
        {
            container.RegisterHandler<LatestPostsViewModel, LatestPostsComponent>("LatestPostsComponent");
        }
    }
}