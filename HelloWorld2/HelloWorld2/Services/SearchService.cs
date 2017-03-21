using HelloWorld2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2.Services
{
     class SearchService
    {
        ObservableCollection<Search> _searchs;
        public SearchService()
        {
            _searchs = new ObservableCollection<Search>
            {
                new Search
                {
                    Id = 1,
                    Location = "São Paulo",
                    CheckIn = new DateTime(2017, 03, 30),
                    CheckOut = new DateTime(2017, 05, 04)
                },
                new Search
                {
                    Id = 2,
                    Location = "Campos do Jordão",
                    CheckIn = new DateTime(2017, 05, 05),
                    CheckOut = new DateTime(2017, 06, 07)
                }
            };
        }
        public IEnumerable<Search> GetSearchs(string filter = null)
        {
            return _searchs;
        }

        public void DeleteSearch(int searchId)
        {

        }
    }
}
