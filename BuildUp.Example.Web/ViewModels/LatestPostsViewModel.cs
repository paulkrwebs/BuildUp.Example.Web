using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildUp.Example.Web.ViewModels
{
    public class LatestPostsViewModel
    {
        public IEnumerable<PostSummary> PostSummaries { get; set; }
    }
}