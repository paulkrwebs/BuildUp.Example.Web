using BuildUp.Example.Web.ContentModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildUp.Example.ContentModels.Pages
{
    public class ContentPage : Content
    {
        public int Id { get; set; }
        public MetaDataContent MetaData { get; set; }
        public string Title { get; set; }
    }
}