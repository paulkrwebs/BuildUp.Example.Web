namespace BuildUp.Example.Web.Components
{
    using BuildUp.Example.Web.ViewModels.Pages;
    using ContentModels;
    using Example.ContentModels;
    using System;
    using System.Collections.Generic;
    using ViewModels;

    public class FooterComponent<TToCreate, TFrom> : IComponent<ComponentArgs<TToCreate, TFrom>>
        where TToCreate : PageViewModel
        where TFrom : Content
    {
        public void Handle(ComponentArgs<TToCreate, TFrom> arg1)
        {
            // Build tree structure from database if not delivered from CMS content model
            List<LinkItemViewModel> links = new List<LinkItemViewModel>()
            {
                new LinkItemViewModel() { Text = "Contact Us", Uri = "/contact-us" },
                new LinkItemViewModel() { Text = "Terms &amp; Conditions", Uri = "/terms-and-conditions" },
            };

            arg1.To.Footer = arg1.To.Footer ?? new FooterViewModel();
            arg1.To.Footer.Links = links;
        }
    }
}