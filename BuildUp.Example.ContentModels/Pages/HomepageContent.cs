using BuildUp.Example.ContentModels.Blocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildUp.Example.ContentModels.Pages
{
    public class HomepageContent : ContentPage
    {
        public string Standfirst { get; set; }
        public IEnumerable<FeaturedItemContent> FeaturedItems { get; set; }
    }
}