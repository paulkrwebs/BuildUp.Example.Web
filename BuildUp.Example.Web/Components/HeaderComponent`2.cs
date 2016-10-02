namespace BuildUp.Example.Web.Components
{
    using BuildUp.Example.Web.ViewModels.Pages;
    using ContentModels;
    using Example.ContentModels;
    using System;
    using System.Collections.Generic;
    using ViewModels;

    public class HeaderComponent<TToCreate, TFrom> : IComponent<ComponentArgs<TToCreate, TFrom>>
        where TToCreate : PageViewModel
        where TFrom : Content
    {
        public void Handle(ComponentArgs<TToCreate, TFrom> arg1)
        {
            // Build tree structure from database if not delivered from CMS content model
            List<LinkItemViewModel> links = new List<LinkItemViewModel>()
            {
                new LinkItemViewModel() { Text = "Our Company", Uri = "/our-company" },
                new LinkItemViewModel() { Text = "People", Uri = "/people" },
            };

            arg1.To.Header = arg1.To.Header ?? new HeaderViewModel();
            arg1.To.Header.Links = links;
        }
    }
}