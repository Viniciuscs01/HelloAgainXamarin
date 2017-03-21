using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2.Models
{
    class SearchGroup : List<Search>
    {
        public string Title { get; set; }

        public SearchGroup(string title)
        {
            Title = title;
        }
    }
}
