using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildUp.Example.Web.ViewModels.Pages
{
    public class HomepageViewModel : PageViewModel
    {
        public bool ShowStandfirst { get; set; }

        public string Standfirst { get; set; }
    }
}