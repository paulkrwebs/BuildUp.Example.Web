namespace BuildUp.Example.Web.Components
{
    using BuildUp.Example.Web.ViewModels.Pages;
    using Example.ContentModels.Pages;
    using ViewModels;

    public class MetaDataComponent<TToCreate, TFrom> :
        IComponent<ComponentArgs<TToCreate, TFrom>>
        where TToCreate : PageViewModel, new()
        where TFrom : ContentPage
    {
        private readonly IPropertyMapper _propertyMapper;

        public MetaDataComponent(IPropertyMapper propertyMapper)
        {
            _propertyMapper = propertyMapper;
        }

        public void Handle(ComponentArgs<TToCreate, TFrom> arg1)
        {
            arg1.ToBuild = arg1.ToBuild ?? new TToCreate();
            arg1.ToBuild.MetaData = arg1.ToBuild.MetaData ?? new MetaDataViewModel();
            _propertyMapper.Map(arg1.From.MetaData, arg1.ToBuild.MetaData);
        }
    }
}