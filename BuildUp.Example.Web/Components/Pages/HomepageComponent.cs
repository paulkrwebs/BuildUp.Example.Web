namespace BuildUp.Example.Web.Components.Pages
{
    using AutoMapper;
    using BuildUp.Example.ContentModels.Pages;
    using BuildUp.Example.Web.ViewModels.Pages;

    public class HomepageComponent :
        Profile,
        IComponent<ComponentArgs<HomepageViewModel, HomepageContent>>
    {
        private readonly IPropertyMapper _propertyMapper;

        public HomepageComponent()
        {
            CreateMap<HomepageContent, HomepageViewModel>().MaxDepth(1);
        }

        public HomepageComponent(IPropertyMapper propertyMapper)
        {
            _propertyMapper = propertyMapper;
        }

        public void Handle(ComponentArgs<HomepageViewModel, HomepageContent> arg1)
        {
            // TODO Guard method and unit test
            _propertyMapper.Map(arg1.From, arg1.To);

            arg1.To.ShowStandfirst = string.IsNullOrWhiteSpace(arg1.To.Standfirst);
        }
    }
}