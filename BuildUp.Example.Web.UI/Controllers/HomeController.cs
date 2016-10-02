namespace BuildUp.Example.Web.UI.Controllers
{
    using BuildUp.Example.Web.ViewModels.Pages;
    using ContentModels;
    using Example.ContentModels.Pages;
    using System.Web.Mvc;

    public class HomeController : BaseController
    {
        public HomeController(IBuilder builder)
            : base(builder)
        { }

        // GET: Home
        public ActionResult Index()
        {
            // Assume this has come from a CMS framework e.g. EPiServer
            var content = new HomepageContent()
            {
                Title = "Title from controller",
                Standfirst = "standfirst from controller",
                MetaData = new MetaDataContent()
                {
                    Keywords = "key1, key2",
                    Description = "description",
                    PageTitle = "Buildup | Homepage"
                }
            };
            var model = Builder.Build<HomepageViewModel, HomepageContent>(content);

            return View(model);
        }
    }
}