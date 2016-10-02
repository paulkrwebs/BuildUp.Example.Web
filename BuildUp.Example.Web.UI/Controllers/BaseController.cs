namespace BuildUp.Example.Web.UI.Controllers
{
    using System.Web.Mvc;

    public class BaseController : Controller
    {
        private readonly IBuilder _builder;

        public BaseController(IBuilder builder)
        {
            _builder = builder;
        }

        protected IBuilder Builder
        {
            get
            {
                return _builder;
            }
        }
    }
}