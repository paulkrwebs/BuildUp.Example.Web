namespace BuildUp.Example.Web.Components
{
    using BuildUp.Example.Web.ViewModels.Pages;
    using Example.ContentModels;

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