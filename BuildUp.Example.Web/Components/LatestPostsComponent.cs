using BuildUp.Example.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildUp.Example.Web.Components
{
    public class LatestPostsComponent : IComponent<ComponentArgs<LatestPostsViewModel>>
    {
        public void Handle(ComponentArgs<LatestPostsViewModel> arg1)
        {
            // load from database
            arg1.ToHandle.PostSummaries = new List<PostSummary>()
            {
                new PostSummary() { Title = "Title 1", Summary = "summary 1" },
                new PostSummary() { Title = "Title 2", Summary = "summary 2" },
                new PostSummary() { Title = "Title 3", Summary = "summary 3" }
            };
        }
    }
}