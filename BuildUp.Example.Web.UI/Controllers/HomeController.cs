namespace BuildUp.Example.Web.UI.Controllers
{
    using BuildUp.Example.Web.ViewModels.Pages;
    using ContentModels;
    using Example.ContentModels.Blocks;
    using Example.ContentModels.Pages;
    using System.Collections.Generic;
    using System.Web.Mvc;

    public class HomeController : BaseController
    {
        public HomeController(IBuilder builder)
            : base(builder)
        { }

        // GET: Home
        public ActionResult Index()
        {
            var content = BuildMockContent();
            var model = Builder.Build<HomepageViewModel, HomepageContent>(content);

            return View(model);
        }

        private static HomepageContent BuildMockContent()
        {
            // Assume this has come from a CMS framework e.g. EPiServer
            return new HomepageContent()
            {
                Title = "Title from controller",
                Standfirst = "standfirst from controller",
                MetaData = new MetaDataContent()
                {
                    Keywords = "key1, key2",
                    Description = "description",
                    PageTitle = "Buildup | Homepage"
                },
                FeaturedItems = new List<FeaturedItemContent>()
                {
                    new FeaturedItemContent() { Title = "Featured item 1", Summary = "Summary Item 1..." },
                    new FeaturedItemContent() { Title = "Featured item 2", Summary = "Summary Item 2..." },
                    new FeaturedItemContent() { Title = "Featured item 3", Summary = "Summary Item 3..." }
                }
            };
        }
    }
}