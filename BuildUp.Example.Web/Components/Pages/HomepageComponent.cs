namespace BuildUp.Example.Web.Components.Pages
{
    using AutoMapper;
    using BuildUp.Example.ContentModels.Pages;
    using BuildUp.Example.Web.ViewModels.Pages;
    using Example.ContentModels.Blocks;
    using System;
    using System.Collections.Generic;
    using ViewModels.Blocks;

    public class HomepageComponent :
        IComponent<ComponentArgs<HomepageViewModel, HomepageContent>>
    {
        private readonly IPropertyMapper _propertyMapper;
        private readonly IBuilder _builder;

        public HomepageComponent(IPropertyMapper propertyMapper, IBuilder builder)
        {
            _propertyMapper = propertyMapper;
            _builder = builder;
        }

        public void Handle(ComponentArgs<HomepageViewModel, HomepageContent> arg1)
        {
            // TODO Guard method and unit test
            _propertyMapper.Map(arg1.From, arg1.To);

            arg1.To.ShowStandfirst = string.IsNullOrWhiteSpace(arg1.To.Standfirst);
            arg1.To.FeaturedItems = BuildFeaturedItems(arg1.From);
        }

        private IEnumerable<FeaturedItemViewModel> BuildFeaturedItems(HomepageContent from)
        {
            foreach (FeaturedItemContent featuredItem in from.FeaturedItems)
            {
                yield return _builder.Build<FeaturedItemViewModel, FeaturedItemContent>(featuredItem);
            }
        }
    }
}