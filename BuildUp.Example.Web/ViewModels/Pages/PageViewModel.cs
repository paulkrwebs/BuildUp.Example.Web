using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildUp.Example.Web.ViewModels.Pages
{
    public class PageViewModel
    {
        public MetaDataViewModel MetaData { get; set; }
        public HeaderViewModel Header { get; set; }
        public string Title { get; set; }
        public FooterViewModel Footer { get; set; }
    }
}