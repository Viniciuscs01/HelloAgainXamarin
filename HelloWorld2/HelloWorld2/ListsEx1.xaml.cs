using HelloWorld2.Models;
using HelloWorld2.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListsEx1 : ContentPage
    {
        public ListsEx1()
        {
            InitializeComponent();
            SearchService searchServ = new SearchService();
            IEnumerable<Search> searchs = searchServ.GetSearchs();
            SearchGroup searchGroup = new SearchGroup("Recent Searchs");
            searchGroup.AddRange(searchs);

            listView.ItemsSource = new ObservableCollection<SearchGroup>
            {
                searchGroup
            };
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void listView_Refreshing(object sender, EventArgs e)
        {

        }
    }
}
