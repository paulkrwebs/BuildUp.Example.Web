namespace BuildUp.Example.Web.Components
{
    using AutoMapper;
    using BuildUp.Example.Web.ViewModels.Pages;
    using ContentModels;
    using Example.ContentModels;
    using System;
    using System.Collections.Generic;
    using ViewModels;

    public class MetaDataComponent<TToCreate, TFrom> :
        IComponent<ComponentArgs<TToCreate, TFrom>>
        where TToCreate : PageViewModel
        where TFrom : Content
    {
        private readonly IPropertyMapper _propertyMapper;

        public MetaDataComponent(IPropertyMapper propertyMapper)
        {
            _propertyMapper = propertyMapper;
        }

        public void Handle(ComponentArgs<TToCreate, TFrom> arg1)
        {
            _propertyMapper.Map(arg1.From, arg1.To);
        }
    }
}