using BuildUp.Example.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BuildUp.Example.Web.UI.Controllers
{
    public class LatestPostsController : BaseController
    {
        public LatestPostsController(IBuilder builder)
            : base(builder)
        { }

        // GET: LatestPosts
        public ActionResult Index()
        {
            var model = Builder.Build<LatestPostsViewModel>();
            return PartialView(model);
        }
    }
}