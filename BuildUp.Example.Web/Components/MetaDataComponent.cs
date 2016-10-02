namespace BuildUp.Example.Web.Components
{
    using AutoMapper;
    using BuildUp.Example.Web.ViewModels.Pages;
    using ContentModels;
    using Example.ContentModels;
    using System;
    using System.Collections.Generic;
    using ViewModels;

    public class MetaDataComponent : Profile
    {
        private readonly IPropertyMapper _propertyMapper;

        public MetaDataComponent()
        {
            CreateMap<MetaDataContent, MetaDataViewModel>().MaxDepth(1);
        }
    }
}